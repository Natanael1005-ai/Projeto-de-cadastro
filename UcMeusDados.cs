using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaUsuarios
{
    /// <summary>
    /// Dashboard do usuario comum: adicionar dados, ver tabela, cartoes de resumo e graficos.
    /// Montado 100% por codigo (sem Designer): e so adicionar o arquivo ao projeto.
    /// Uso: new UcMeusDados(idDoUsuarioLogado)
    /// </summary>
    public class UcMeusDados : UserControl
    {
        private readonly int _idUsuario;
        private readonly RegistroDAO _dao = new RegistroDAO();
        private readonly CultureInfo _pt = new CultureInfo("pt-BR");

        private DateTimePicker dtpData = null!;
        private ComboBox cboCategoria = null!;
        private NumericUpDown nudValor = null!;
        private TextBox txtDescricao = null!;
        private Button btnAdicionar = null!;
        private Button btnExcluir = null!;
        private DataGridView dgv = null!;
        private Label lblTotal = null!, lblMedia = null!, lblQtd = null!;
        private Chart chartCategoria = null!, chartMes = null!;

        public UcMeusDados(int idUsuario)
        {
            _idUsuario = idUsuario;
            Dock = DockStyle.Fill;
            BackColor = Color.WhiteSmoke;
            MontarTela();
            CarregarDados();
        }

        // ---------------------------------------------------------------- Layout

        private void MontarTela()
        {
            var raiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(10)
            };
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(raiz);

            // Linha 1: cartoes de resumo
            var cartoes = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false };
            cartoes.Controls.Add(CriarCartao("Total", out lblTotal));
            cartoes.Controls.Add(CriarCartao("Media por registro", out lblMedia));
            cartoes.Controls.Add(CriarCartao("Registros", out lblQtd));
            raiz.Controls.Add(cartoes, 0, 0);

            // Linha 2: formulario de entrada
            var entrada = new FlowLayoutPanel { Dock = DockStyle.Fill, WrapContents = false };

            dtpData = new DateTimePicker { Format = DateTimePickerFormat.Short, Width = 105 };
            cboCategoria = new ComboBox { Width = 140, DropDownStyle = ComboBoxStyle.DropDown };
            nudValor = new NumericUpDown
            {
                Width = 105,
                DecimalPlaces = 2,
                Minimum = 0,
                Maximum = 999999999,
                ThousandsSeparator = true
            };
            txtDescricao = new TextBox { Width = 200, MaxLength = 200 };
            btnAdicionar = new Button { Text = "Adicionar", Width = 90, Height = 28 };
            btnAdicionar.Click += BtnAdicionar_Click;

            entrada.Controls.Add(CriarRotulo("Data"));
            entrada.Controls.Add(dtpData);
            entrada.Controls.Add(CriarRotulo("Categoria"));
            entrada.Controls.Add(cboCategoria);
            entrada.Controls.Add(CriarRotulo("Valor"));
            entrada.Controls.Add(nudValor);
            entrada.Controls.Add(CriarRotulo("Descricao"));
            entrada.Controls.Add(txtDescricao);
            entrada.Controls.Add(btnAdicionar);
            raiz.Controls.Add(entrada, 0, 1);

            // Linha 3: tabela (esquerda) e graficos (direita)
            var conteudo = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1 };
            conteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            conteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            raiz.Controls.Add(conteudo, 0, 2);

            var esquerda = new Panel { Dock = DockStyle.Fill };
            dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                BackgroundColor = Color.White
            };
            btnExcluir = new Button { Text = "Excluir selecionado", Dock = DockStyle.Bottom, Height = 32 };
            btnExcluir.Click += BtnExcluir_Click;
            esquerda.Controls.Add(dgv);
            esquerda.Controls.Add(btnExcluir);
            conteudo.Controls.Add(esquerda, 0, 0);

            var direita = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            direita.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            direita.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            chartCategoria = CriarGrafico("Total por categoria", SeriesChartType.Column);
            chartMes = CriarGrafico("Evolucao por mes", SeriesChartType.Line);
            direita.Controls.Add(chartCategoria, 0, 0);
            direita.Controls.Add(chartMes, 0, 1);
            conteudo.Controls.Add(direita, 1, 0);
        }

        private Panel CriarCartao(string titulo, out Label lblValor)
        {
            var painel = new Panel
            {
                Width = 200,
                Height = 68,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 10, 0)
            };
            var lblTitulo = new Label
            {
                Text = titulo,
                Dock = DockStyle.Top,
                Height = 22,
                ForeColor = Color.Gray,
                Padding = new Padding(8, 4, 0, 0)
            };
            lblValor = new Label
            {
                Text = "-",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15f, FontStyle.Bold),
                Padding = new Padding(8, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft
            };
            painel.Controls.Add(lblValor);
            painel.Controls.Add(lblTitulo);
            return painel;
        }

        private Label CriarRotulo(string texto)
        {
            return new Label
            {
                Text = texto,
                AutoSize = true,
                Margin = new Padding(8, 7, 2, 0)
            };
        }

        private Chart CriarGrafico(string titulo, SeriesChartType tipo)
        {
            var chart = new Chart { Dock = DockStyle.Fill, BackColor = Color.White };
            chart.ChartAreas.Add(new ChartArea("area"));
            chart.ChartAreas["area"].AxisX.MajorGrid.Enabled = false;
            chart.Titles.Add(titulo);

            var serie = new Series("dados")
            {
                ChartType = tipo,
                IsValueShownAsLabel = true,
                LabelFormat = "N2"
            };
            if (tipo == SeriesChartType.Line)
            {
                serie.BorderWidth = 3;
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.MarkerSize = 8;
            }
            chart.Series.Add(serie);
            return chart;
        }

        // ---------------------------------------------------------------- Dados

        private void CarregarDados()
        {
            List<Registro> lista;
            try
            {
                lista = _dao.ListarPorUsuario(_idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tabela
            dgv.DataSource = lista.Select(r => new
            {
                r.Id,
                Data = r.Data.ToString("dd/MM/yyyy"),
                r.Categoria,
                Valor = r.Valor.ToString("N2", _pt),
                Descricao = r.Descricao
            }).ToList();
            if (dgv.Columns["Id"] != null) dgv.Columns["Id"].Visible = false;

            // Categorias ja usadas viram sugestoes no combo
            string digitado = cboCategoria.Text;
            cboCategoria.Items.Clear();
            foreach (var c in lista.Select(r => r.Categoria).Distinct().OrderBy(c => c))
                cboCategoria.Items.Add(c);
            cboCategoria.Text = digitado;

            // Cartoes
            decimal total = lista.Sum(r => r.Valor);
            lblTotal.Text = total.ToString("N2", _pt);
            lblMedia.Text = lista.Count > 0 ? (total / lista.Count).ToString("N2", _pt) : "0,00";
            lblQtd.Text = lista.Count.ToString();

            // Grafico por categoria
            var porCategoria = lista
                .GroupBy(r => r.Categoria)
                .Select(g => new { Nome = g.Key, Total = g.Sum(x => x.Valor) })
                .OrderByDescending(x => x.Total)
                .ToList();

            var serieCat = chartCategoria.Series["dados"];
            serieCat.Points.Clear();
            foreach (var item in porCategoria)
                serieCat.Points.AddXY(item.Nome, (double)item.Total);

            // Grafico por mes
            var porMes = lista
                .GroupBy(r => new DateTime(r.Data.Year, r.Data.Month, 1))
                .Select(g => new { Mes = g.Key, Total = g.Sum(x => x.Valor) })
                .OrderBy(x => x.Mes)
                .ToList();

            var serieMes = chartMes.Series["dados"];
            serieMes.Points.Clear();
            foreach (var item in porMes)
                serieMes.Points.AddXY(item.Mes.ToString("MM/yyyy"), (double)item.Total);
        }

        // ---------------------------------------------------------------- Eventos

        private void BtnAdicionar_Click(object? sender, EventArgs e)
        {
            string categoria = cboCategoria.Text.Trim();

            if (categoria.Length == 0)
            {
                MessageBox.Show("Informe a categoria.", "Atencao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.Focus();
                return;
            }
            if (nudValor.Value <= 0)
            {
                MessageBox.Show("Informe um valor maior que zero.", "Atencao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudValor.Focus();
                return;
            }

            try
            {
                _dao.Inserir(new Registro
                {
                    IdUsuario = _idUsuario,
                    Data = dtpData.Value.Date,
                    Categoria = categoria,
                    Valor = nudValor.Value,
                    Descricao = txtDescricao.Text.Trim()
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nudValor.Value = 0;
            txtDescricao.Clear();
            CarregarDados();
        }

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;

            var confirma = MessageBox.Show("Excluir o registro selecionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
                _dao.Excluir(id, _idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregarDados();
        }
    }
}
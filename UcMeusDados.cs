using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaUsuarios
{
    public class UcMeusDados : UserControl
    {
        private readonly int _idUsuario;
        private readonly RegistroDAO _dao = new RegistroDAO();
        private readonly CultureInfo _pt = new CultureInfo("pt-BR");

        // Paleta visual do sistema
        private readonly Color corPrincipal = Color.FromArgb(30, 30, 46);
        private readonly Color corHover = Color.FromArgb(50, 50, 72);
        private readonly Color corFundo = Color.White;
        private readonly Color corTexto = Color.FromArgb(30, 30, 46);
        private readonly Color corSecundaria = Color.FromArgb(120, 120, 130);
        private readonly Color corBorda = Color.FromArgb(225, 225, 235);

        private DateTimePicker dtpData = null!;
        private ComboBox cboCategoria = null!;
        private NumericUpDown nudValor = null!;
        private TextBox txtDescricao = null!;

        private Button btnAdicionar = null!;
        private Button btnExcluir = null!;

        private DataGridView dgv = null!;

        private Label lblTotal = null!;
        private Label lblMedia = null!;
        private Label lblQtd = null!;

        private Chart chartCategoria = null!;
        private Chart chartMes = null!;

        public UcMeusDados(int idUsuario)
        {
            _idUsuario = idUsuario;

            Dock = DockStyle.Fill;
            BackColor = Color.FromArgb(245, 246, 250);
            Font = new Font("Segoe UI", 10F);

            MontarTela();
            CarregarDados();
        }

        // ---------------------------------------------------------
        // LAYOUT PRINCIPAL
        // ---------------------------------------------------------

        private void MontarTela()
        {
            var raiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(15),
                BackColor = Color.FromArgb(245, 246, 250)
            };

            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 75));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            Controls.Add(raiz);

            // -----------------------------------------------------
            // CARTÕES DE RESUMO
            // -----------------------------------------------------

            var cartoes = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 0, 0, 10)
            };

            for (int i = 0; i < 3; i++)
                cartoes.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 33.33F));

            cartoes.Controls.Add(
                CriarCartao("TOTAL ACUMULADO", out lblTotal), 0, 0);

            cartoes.Controls.Add(
                CriarCartao("MÉDIA POR REGISTRO", out lblMedia), 1, 0);

            cartoes.Controls.Add(
                CriarCartao("QUANTIDADE DE REGISTROS", out lblQtd), 2, 0);

            raiz.Controls.Add(cartoes, 0, 0);

            // -----------------------------------------------------
            // FORMULÁRIO DE ENTRADA
            // -----------------------------------------------------

            var entrada = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(5, 8, 5, 0),
                Margin = new Padding(0, 0, 0, 10)
            };

            dtpData = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Width = 105,
                Font = new Font("Segoe UI", 9.5F),
                Margin = new Padding(3, 5, 10, 0)
            };

            cboCategoria = new ComboBox
            {
                Width = 140,
                DropDownStyle = ComboBoxStyle.DropDown,
                Font = new Font("Segoe UI", 9.5F),
                Margin = new Padding(3, 5, 10, 0)
            };

            nudValor = new NumericUpDown
            {
                Width = 105,
                DecimalPlaces = 2,
                Minimum = 0,
                Maximum = 999999999,
                ThousandsSeparator = true,
                Font = new Font("Segoe UI", 9.5F),
                Margin = new Padding(3, 5, 10, 0)
            };

            txtDescricao = new TextBox
            {
                Width = 180,
                MaxLength = 200,
                Font = new Font("Segoe UI", 9.5F),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3, 5, 10, 0)
            };

            btnAdicionar = new Button
            {
                Text = "＋ Adicionar",
                Width = 115,
                Height = 32,
                Margin = new Padding(3, 2, 3, 0)
            };

            EstilizarBotaoPrincipal(btnAdicionar);

            btnAdicionar.Click += BtnAdicionar_Click;

            entrada.Controls.Add(CriarRotulo("Data"));
            entrada.Controls.Add(dtpData);

            entrada.Controls.Add(CriarRotulo("Categoria"));
            entrada.Controls.Add(cboCategoria);

            entrada.Controls.Add(CriarRotulo("Valor"));
            entrada.Controls.Add(nudValor);

            entrada.Controls.Add(CriarRotulo("Descrição"));
            entrada.Controls.Add(txtDescricao);

            entrada.Controls.Add(btnAdicionar);

            raiz.Controls.Add(entrada, 0, 1);

            // -----------------------------------------------------
            // CONTEÚDO: TABELA + GRÁFICOS
            // -----------------------------------------------------

            var conteudo = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.Transparent,
                Margin = new Padding(0)
            };

            conteudo.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 48));

            conteudo.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 52));

            raiz.Controls.Add(conteudo, 0, 2);

            // -----------------------------------------------------
            // PAINEL DA TABELA
            // -----------------------------------------------------

            var esquerda = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(0, 0, 8, 0)
            };

            var lblTabela = new Label
            {
                Text = "MEUS REGISTROS",
                Dock = DockStyle.Top,
                Height = 35,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = corPrincipal,
                TextAlign = ContentAlignment.MiddleLeft
            };

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

                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,

                EnableHeadersVisualStyles = false,

                GridColor = corBorda,

                Font = new Font("Segoe UI", 9.5F),

                ColumnHeadersHeight = 40,
                RowTemplate = { Height = 35 },

                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = corPrincipal,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    Padding = new Padding(5)
                },

                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = corTexto,
                    SelectionBackColor = Color.FromArgb(225, 225, 240),
                    SelectionForeColor = corPrincipal,
                    Padding = new Padding(5)
                },

                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(245, 246, 250),
                    ForeColor = corTexto,
                    SelectionBackColor = Color.FromArgb(225, 225, 240),
                    SelectionForeColor = corPrincipal
                }
            };

            btnExcluir = new Button
            {
                Text = "Excluir selecionado",
                Dock = DockStyle.Bottom,
                Height = 38,
                Margin = new Padding(0, 5, 0, 0)
            };

            EstilizarBotaoSecundario(btnExcluir);

            btnExcluir.Click += BtnExcluir_Click;

            esquerda.Controls.Add(dgv);
            esquerda.Controls.Add(lblTabela);
            esquerda.Controls.Add(btnExcluir);

            conteudo.Controls.Add(esquerda, 0, 0);

            // -----------------------------------------------------
            // PAINEL DOS GRÁFICOS
            // -----------------------------------------------------

            var direita = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.Transparent,
                Margin = new Padding(8, 0, 0, 0)
            };

            direita.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50));

            direita.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50));

            chartCategoria = CriarGrafico(
                "Total por categoria",
                SeriesChartType.Column);

            chartMes = CriarGrafico(
                "Evolução por mês",
                SeriesChartType.Line);

            direita.Controls.Add(chartCategoria, 0, 0);
            direita.Controls.Add(chartMes, 0, 1);

            conteudo.Controls.Add(direita, 1, 0);
        }

        // ---------------------------------------------------------
        // CARTÕES DE RESUMO
        // ---------------------------------------------------------

        private Panel CriarCartao(string titulo, out Label lblValor)
        {
            var painel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 10, 0),
                Padding = new Padding(10)
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Dock = DockStyle.Top,
                Height = 28,
                ForeColor = corSecundaria,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            lblValor = new Label
            {
                Text = "0,00",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = corPrincipal,
                TextAlign = ContentAlignment.MiddleLeft
            };

            painel.Controls.Add(lblValor);
            painel.Controls.Add(lblTitulo);

            return painel;
        }

        // ---------------------------------------------------------
        // RÓTULOS DOS CAMPOS
        // ---------------------------------------------------------

        private Label CriarRotulo(string texto)
        {
            return new Label
            {
                Text = texto,
                AutoSize = true,
                ForeColor = Color.FromArgb(90, 90, 100),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Margin = new Padding(8, 10, 2, 0)
            };
        }

        // ---------------------------------------------------------
        // ESTILO DOS BOTÕES
        // ---------------------------------------------------------

        private void EstilizarBotaoPrincipal(Button botao)
        {
            botao.BackColor = corPrincipal;
            botao.ForeColor = Color.White;

            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatAppearance.MouseOverBackColor = corHover;

            botao.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            botao.Cursor = Cursors.Hand;

            botao.UseVisualStyleBackColor = false;
        }

        private void EstilizarBotaoSecundario(Button botao)
        {
            botao.BackColor = Color.FromArgb(235, 235, 242);
            botao.ForeColor = corPrincipal;

            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(215, 215, 225);

            botao.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            botao.Cursor = Cursors.Hand;

            botao.UseVisualStyleBackColor = false;
        }

        // ---------------------------------------------------------
        // GRÁFICOS
        // ---------------------------------------------------------

        private Chart CriarGrafico(string titulo, SeriesChartType tipo)
        {
            var chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(0, 0, 0, 8)
            };

            var area = new ChartArea("area");

            area.BackColor = Color.White;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = corBorda;

            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);

            area.AxisX.LabelStyle.ForeColor = corSecundaria;
            area.AxisY.LabelStyle.ForeColor = corSecundaria;

            area.AxisX.LineColor = corBorda;
            area.AxisY.LineColor = corBorda;

            chart.ChartAreas.Add(area);

            var tituloGrafico = new Title(titulo)
            {
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = corPrincipal
            };

            chart.Titles.Add(tituloGrafico);

            var serie = new Series("dados")
            {
                ChartType = tipo,
                IsValueShownAsLabel = true,
                LabelFormat = "N2",

                Color = Color.FromArgb(70, 100, 180),

                Font = new Font("Segoe UI", 8F, FontStyle.Bold),

                BorderWidth = 3
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

        // ---------------------------------------------------------
        // CARREGAMENTO DOS DADOS
        // ---------------------------------------------------------

        private void CarregarDados()
        {
            List<Registro> lista;

            try
            {
                lista = _dao.ListarPorUsuario(_idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar os dados: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

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

            if (dgv.Columns["Id"] != null)
                dgv.Columns["Id"].Visible = false;

            // Categorias já usadas viram sugestões no combo
            string digitado = cboCategoria.Text;

            cboCategoria.Items.Clear();

            foreach (var c in lista
                .Select(r => r.Categoria)
                .Distinct()
                .OrderBy(c => c))
            {
                cboCategoria.Items.Add(c);
            }

            cboCategoria.Text = digitado;

            // Cartões
            decimal total = lista.Sum(r => r.Valor);

            lblTotal.Text = total.ToString("N2", _pt);

            lblMedia.Text = lista.Count > 0
                ? (total / lista.Count).ToString("N2", _pt)
                : "0,00";

            lblQtd.Text = lista.Count.ToString();

            // Gráfico por categoria
            var porCategoria = lista
                .GroupBy(r => r.Categoria)
                .Select(g => new
                {
                    Nome = g.Key,
                    Total = g.Sum(x => x.Valor)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            var serieCat = chartCategoria.Series["dados"];

            serieCat.Points.Clear();

            foreach (var item in porCategoria)
            {
                serieCat.Points.AddXY(
                    item.Nome,
                    (double)item.Total);
            }

            // Gráfico por mês
            var porMes = lista
                .GroupBy(r => new DateTime(
                    r.Data.Year,
                    r.Data.Month,
                    1))
                .Select(g => new
                {
                    Mes = g.Key,
                    Total = g.Sum(x => x.Valor)
                })
                .OrderBy(x => x.Mes)
                .ToList();

            var serieMes = chartMes.Series["dados"];

            serieMes.Points.Clear();

            foreach (var item in porMes)
            {
                serieMes.Points.AddXY(
                    item.Mes.ToString("MM/yyyy"),
                    (double)item.Total);
            }
        }

        // ---------------------------------------------------------
        // ADICIONAR REGISTRO
        // ---------------------------------------------------------

        private void BtnAdicionar_Click(object? sender, EventArgs e)
        {
            string categoria = cboCategoria.Text.Trim();

            if (categoria.Length == 0)
            {
                MessageBox.Show(
                    "Informe a categoria.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboCategoria.Focus();
                return;
            }

            if (nudValor.Value <= 0)
            {
                MessageBox.Show(
                    "Informe um valor maior que zero.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
                MessageBox.Show(
                    "Erro ao salvar: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            nudValor.Value = 0;
            txtDescricao.Clear();

            CarregarDados();
        }

        // ---------------------------------------------------------
        // EXCLUIR REGISTRO
        // ---------------------------------------------------------

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
                return;

            var confirma = MessageBox.Show(
                "Excluir o registro selecionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(
                    dgv.CurrentRow.Cells["Id"].Value);

                _dao.Excluir(id, _idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao excluir: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            CarregarDados();
        }

        private void InitializeComponent()
        {
            // A interface é montada pelo método MontarTela().
        }
    }
}


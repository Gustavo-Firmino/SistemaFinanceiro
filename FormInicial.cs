namespace SistemaFinanceiro
{
    public partial class FormInicial : Form
    {
        private Button[] BotoesMenuLateral;

        public FormInicial()
        {
            InitializeComponent();

            BotoesMenuLateral = [BtnDashboard, BtnDespesas, BtnReceitas]; 

            InicializarGUIFormInicial();
            InicializarGUIMenuLateral();
        }

        private void InicializarGUIFormInicial()
        {
            PnlMenuLateral.Padding = new Padding(20, 0, 20, 0);

            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            MinimumSize = new Size(1500, 800);

            Text = "Sistema Financeiro";
        }

        private void InicializarGUIMenuLateral()
        {
            PnlMenuLateral.BackColor = ColorTranslator.FromHtml("#212429");

            InicializarSessaoLogo();

            InicializarLinhaSeparacao(PnlLinhaLogo);
            InicializarLinhaSeparacao(PnlLinhaRodape);

            InicializarBtnMenuLateral(BtnDashboard, BtnDespesas, BtnReceitas);
            AtribuirEventosBotoesMenuLateral();
        }

        private void AtribuirEventosBotoesMenuLateral()
        {
            EventoBtnDashboard();
        }

        private void EventoBtnDashboard()
        {
            BtnDashboard.Click += (s, e) =>
            {
                DestacarBotao(BtnDashboard);
            };
        }

        private void DestacarBotao(Button botaoClicado)
        {
            // Cor de fundo que voc� quer para o selecionado
            var corDestaque = ColorTranslator.FromHtml("#0D6EFD");

            foreach (var btn in BotoesMenuLateral)
            {
                // Define o BackColor normal
                var isSelecionado = btn == botaoClicado;
                
                btn.BackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;

                // Redefine tamb�m as cores de hover / mouse-down
                btn.FlatAppearance.MouseOverBackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;
                btn.FlatAppearance.MouseDownBackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;
            }
        }

        private void InicializarSessaoLogo()
        {
            LblTitulo.Text = "Sistema Financeiro";
            LblTitulo.AutoSize = true;

            LblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LblTitulo.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void InicializarLinhaSeparacao(Panel panel)
        {
            panel.BackColor = ColorTranslator.FromHtml("#45494E");
        }

        private void InicializarBtnMenuLateral(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                // Garante que o bot�o herde o BackColor do seu pai
                button.Parent = PnlMenuLateral;
                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.Transparent;

                // Usa o estilo Flat para remover as bordas e fundo padr�o
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;

                // Fonte e cor
                button.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                button.ForeColor = Color.White;

                button.TextAlign = ContentAlignment.MiddleLeft;
                // Padding interno para n�o ficar encostado na borda
                button.Padding = new Padding(10, 0, 0, 0);

                button.Cursor = Cursors.Hand;
            }
        }
    }
}
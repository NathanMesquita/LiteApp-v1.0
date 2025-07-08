namespace LiteApp {
    public partial class Form1 : Form {
        private List<Contato> ListaContatos = new List<Contato>();

        public Form1() {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            String nome = txtNome.Text.Trim();
            String telefone = txtTelefone.Text.Trim();

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            Contato novoContato = new Contato(nome, telefone);
            ListaContatos.Add(novoContato);

            AtualizarLista();
            LimparCampos();
        }

        private void AtualizarLista() {
            lstContatos.Items.Clear();
            foreach (Contato contato in ListaContatos)
            {
                lstContatos.Items.Add($"{contato.Nome} - {contato.Telefone}");
            }
        }

        private void LimparCampos() {
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            LimparCampos();
        }
    }

    public class Contato {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, string telefone) {
            Nome = nome;
            Telefone = telefone;
        }
    }
}

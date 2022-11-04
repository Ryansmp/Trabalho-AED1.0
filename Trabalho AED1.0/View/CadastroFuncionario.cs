using Trabalho_AED1._0.Model;

namespace Trabalho_AED1._0
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextoNome_TextChanged(object sender, EventArgs e)
        {

        }


        private void TextoCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinCadastro_Click(object sender, EventArgs e)
        {

            if (TextoNome.Text.Length == 0 && TextoCPF.Text.Length == 0 && TextoSenha.Text.Length == 0 && TextoCargo.Text.Length == 0 && TextoGestor.Text.Length == 0)
            {
                MessageBox.Show(this, "Impossível finalizar o cadastro, preencha todos os campos para finalizar o cadastro ");
            }



            else if (TextoNome.Text.Length == 0)
                {
                    MessageBox.Show(this, "Preencha o campo do nome para finalizar o cadastro");
                }
   
            
               else  if (TextoCPF.Text.Length == 0)
                {
                    MessageBox.Show(this, "Preencha o campo do CPF para finalizar o cadastro");
                }
                
            
                else if (TextoSenha.Text.Length == 0)
                {
                    MessageBox.Show(this, "Preencha o campo do Senha para finalizar o cadastro");
                }

                else  if (TextoCargo.Text.Length == 0)
                {
                    MessageBox.Show(this, "Preencha o campo do Cargo para finalizar o cadastro");
                }

                else if (TextoGestor.Text.Length == 0)
                {
                    MessageBox.Show(this, "Digite algo no campo 5");
                }


            else 
            {
                MessageBox.Show("Cadastro Finalizado!");
                SalvaFunc();
            }
        }

         void SalvaFunc()//Salva o arquivo em Json
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = TextoNome.Text;
            funcionario.Cpf = TextoCPF.Text;
            funcionario.Senha = TextoSenha.Text;
            funcionario.Cargo = TextoCargo.Text;
            funcionario.CpfGestor = TextoGestor.Text;

            Funcionarios funcionarios = new Funcionarios();
            funcionarios.SalvaCadastro(funcionario);
        }

    }
}
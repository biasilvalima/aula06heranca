namespace aula06heranca
{
    // Aqui chamou a classe pai e pode usar seus atributos
    public class CPF : pessoa
    {
        public string cpf;
        
        public string rg;
    /// <summary>
    /// Valida CPF
    /// </summary>
    /// <returns>Cpf validado ou não (true or false)</returns>
        public bool ValidarCPF(){
            if(cpf != ""){
                return true;
            }
            return false;
        }

    }
}
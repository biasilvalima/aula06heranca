namespace aula06heranca
{
    // Aqui chamou a classe pai e pode usar seus atributos
    public class CNPJ : pessoa
    {
        public string cnpj;
        /// <summary>
        /// Validaçao do CNPJ
        /// </summary>
        /// <returns>cpf validado ou nao (true or false)</returns>
        public bool ValidarCNPJ(){
            if(cnpj != "" ){
                return true;
            }
            return false;
        }
    }
}
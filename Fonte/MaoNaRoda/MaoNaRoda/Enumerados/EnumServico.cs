namespace MaoNaRoda.Enumerados
{
    public class EnumServico:EnumBase
    {
        public static List<SelecionarOpcao> ObterOpcoes<T>()
        {
            try
            {
                var tipo = typeof(T);
                var resultado = Enum.GetNames(tipo).Select(
                        item => new SelecionarOpcao
                        {
                            Objeto = Enum.Parse(tipo, item),
                            Descricao = GetDescricao<T>(item)
                        }
                    ).ToList();

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao criar lista de opções baseado: {ex.Message}");
            }
        }
    }
}

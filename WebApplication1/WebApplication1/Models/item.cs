namespace WebApplication1.Models
{
    public class item
    {
        public int ItemID { get; set; }
        public string Nome { get; set; }
        public int Descricao { get; set; }
        public int DanoMaximo { get; set; }
        public int Raridade { get; set; }
        //Relacionamento do Item --> TipoItem
        public int TipoItemID { get; set; }
        public virtual TipoItem :_TipoItem { get; set; }
    }
}
namespace QuickBuy.dominio.Entidades
{
    public class MyString
    {
        public int Id { get; set; }
        public string MyStr { get; set; }

        public MyString(string myStr)
        {
            MyStr = myStr;
        }

        public MyString() { }
    }
}
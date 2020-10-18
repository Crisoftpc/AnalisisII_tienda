namespace MyCompany.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("ProductosFotografia", "\"dbo\".\"Productos\"", "\"Fotografia\"", new string[] {
                        "\"IdProducto\""}, "Productos Fotografia", "Productos", "Fotografia");
        }
    }
}

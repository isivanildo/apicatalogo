using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) values('Bebidas', 'bebidas.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) values('Lanches', 'lanches.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) values('Sobremesa', 'sobremesa.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}

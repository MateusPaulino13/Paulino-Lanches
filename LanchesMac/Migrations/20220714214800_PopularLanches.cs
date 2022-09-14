using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhados com batata palha', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho com queijo derretido; presunto e queijo de primeira qualidade', 1, 'https://sg-delivery.s3.sa-east-1.amazonaws.com/upload/images/171657202005305ed2bf392c549.jpeg', 'https://sg-delivery.s3.sa-east-1.amazonaws.com/upload/images/171657202005305ed2bf392c549.jpeg', 0, 'Misto Quente', 8.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, hambúrguer, hambúrguer, queijo e molho especial', 'Delicioso pão de hambúrguer com um hambúrguer suculento; queijo de primeira qualidade acompanhados com molho especial', 1, 'https://img.freepik.com/fotos-gratis/saboroso-hamburguer-de-carne-com-queijo-e-salada-de-frente-no-fundo-escuro_140725-89597.jpg', 'https://img.freepik.com/fotos-gratis/saboroso-hamburguer-de-carne-com-queijo-e-salada-de-frente-no-fundo-escuro_140725-89597.jpg', 0, 'Cheese Burguer', 11.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(2, 'Pão, Peito de Peru, Cenoura ralada, Tomate, Alface e Patê de Atum', 'Delicioso lanche natural para refeições mais saborosas; Hortaliças de primeira qualidade acompanhados com Patê de Atum', 1, 'http://guiadacozinha.com.br/wp-content/uploads/2019/10/lanche-natural-light-51401.jpg', 'http://guiadacozinha.com.br/wp-content/uploads/2019/10/lanche-natural-light-51401.jpg', 1, 'Lanche Natural', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}

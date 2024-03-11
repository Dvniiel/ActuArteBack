﻿// <auto-generated />
using ActuArte.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ActuArte.Data.Migrations
{
    [DbContext(typeof(ActuArteContext))]
    partial class ActuArteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActuArte.Models.Asientos", b =>
                {
                    b.Property<int>("idAsiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAsiento"));

                    b.Property<bool>("estaOcupado")
                        .HasColumnType("bit");

                    b.Property<int>("idObra")
                        .HasColumnType("int");

                    b.HasKey("idAsiento");

                    b.ToTable("Asientos");

                    b.HasData(
                        new
                        {
                            idAsiento = 1,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 2,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 3,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 4,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 5,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 6,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 7,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 8,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 9,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 10,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 11,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 12,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 13,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 14,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 15,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 16,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 17,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 18,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 19,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 20,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 21,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 22,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 23,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 24,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 25,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 26,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 27,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 28,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 29,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 30,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 31,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 32,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 33,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 34,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 35,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 36,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 37,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 38,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 39,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 40,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 41,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 42,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 43,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 44,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 45,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 46,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 47,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 48,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 49,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 50,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 51,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 52,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 53,
                            estaOcupado = false,
                            idObra = 0
                        },
                        new
                        {
                            idAsiento = 54,
                            estaOcupado = false,
                            idObra = 0
                        });
                });

            modelBuilder.Entity("ActuArte.Models.AsientosGuardados", b =>
                {
                    b.Property<int>("idObjeto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idObjeto"));

                    b.Property<int>("idAsiento")
                        .HasColumnType("int");

                    b.Property<int>("idObra")
                        .HasColumnType("int");

                    b.Property<int>("idSesion")
                        .HasColumnType("int");

                    b.HasKey("idObjeto");

                    b.ToTable("AsientosGuardados");
                });

            modelBuilder.Entity("ActuArte.Models.Obras", b =>
                {
                    b.Property<int>("idObra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idObra"));

                    b.Property<bool>("aclamadas")
                        .HasColumnType("bit");

                    b.Property<string>("autorObra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descObra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("directorObra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duracionObra")
                        .HasColumnType("int");

                    b.Property<string>("imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreObra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("recientes")
                        .HasColumnType("bit");

                    b.Property<bool>("ultimasSesiones")
                        .HasColumnType("bit");

                    b.Property<double>("valoracionObra")
                        .HasColumnType("float");

                    b.HasKey("idObra");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            idObra = 1,
                            aclamadas = true,
                            autorObra = "Nayra Calvo y Miguel A.Luengo",
                            descObra = "La excelente y lamentable tragedia de Romeo y Julieta cuenta la historia de dos jóvenes enamorados, Romeo y Julieta, quienes pertenecen a dos familias poderosas y enemigas de la ciudad renacentista de Verona, Italia: los Montesco y los Capuleto. Los protagonistas se conocen en un baile familiar de los Capuleto, en el que Romeo y sus amigos se cuelan, a pesar del peligro que corren y de que el rey de la ciudad ha decretado una frágil tregua entre las familias. Y tan pronto como bailan, Romeo y Julieta quedan perdidamente enamorados el uno del otro.",
                            directorObra = "Franco Zeffirelli",
                            duracionObra = 90,
                            imagen = "https://almeriaciudad.es/cultura/wp-content/archivos/sites/21/2022/02/IMG_2391-1.jpeg",
                            nombreObra = "Romeo y Julieta",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 5.0
                        },
                        new
                        {
                            idObra = 2,
                            aclamadas = false,
                            autorObra = "Nancy Fabiola Herrera y Carmen Romeu",
                            descObra = "Tras la muerte de su segundo esposo, Bernarda Alba se recluye e impone un luto riguroso y asfixiante por ocho años, prohibiendo a sus cinco hijas a que vayan a la fiesta. Cuando Angustias, la primogénita y la única hija del primer marido, hereda una fortuna, atrae a un pretendiente, Pepe el Romano.",
                            directorObra = "Alfredo Sanzol",
                            duracionObra = 60,
                            imagen = "https://chglenguayliteratura.files.wordpress.com/2020/01/aaaa.jpg",
                            nombreObra = "La Casa de Bernarda Alba",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.2999999999999998
                        },
                        new
                        {
                            idObra = 3,
                            aclamadas = true,
                            autorObra = "Cobadonga Calderon y Javier Mañon",
                            descObra = "La loca pasión por Melibea, hija de un rico mercader, lleva al joven Calisto a romper todas las barreras y a aliarse con una vieja alcahueta. Desde el momento en que entra en escena, Celestina avasalla toda la obra hasta convertirse en un personaje literario de fama universal.",
                            directorObra = "Antonio Castro Guijosa",
                            duracionObra = 60,
                            imagen = "https://www.cervantesvirtual.com/s3/BVMC_OBRAS/ffa/c66/288/2b1/11d/fac/c70/021/85c/e60/64/mimes/imagenes/ffac6628-82b1-11df-acc7-002185ce6064_2.jpg",
                            nombreObra = "La Celestina",
                            recientes = true,
                            ultimasSesiones = false,
                            valoracionObra = 4.7000000000000002
                        },
                        new
                        {
                            idObra = 4,
                            aclamadas = false,
                            autorObra = "David Luque y Rebeca Matellan",
                            descObra = "El rey Basilio va a tener un hijo. Pero un adivino le dice que ese nacimiento traerá el desastre al reino. En efecto, nada más nacer la madre muere, y el rey, asustado encierra a su hijo en una torre escondida entre montañas de forma que nadie sepa donde está. Solo Clotaldo, su ayo, conoce su paradero.",
                            directorObra = "Declan Deonnellan",
                            duracionObra = 100,
                            imagen = "https://www.elejandria.com/covers/La_vida_es_sueno-Calderon_de_la_Barca_Pedro-md.png",
                            nombreObra = "La Vida es Sueño",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.4000000000000004
                        },
                        new
                        {
                            idObra = 5,
                            aclamadas = true,
                            autorObra = "Juan Motilla y Antonio Campos",
                            descObra = "La tragedia de Hamlet, Príncipe de Dinamarca cuenta la historia del joven heredero al trono danés, cuyo padre muerto se le aparece como un fantasma en las murallas del castillo, para invocar su venganza, pues su muerte no fue natural sino que fue envenenado por su propia esposa Gertrudis, madre de Hamlet, y su hermano y actual rey, Claudio.",
                            directorObra = "Miguel del Arco",
                            duracionObra = 95,
                            imagen = "https://cdn.kobo.com/book-images/5fc4252b-1c4f-40ef-9975-22982c94f12c/1200/1200/False/hamlet-prince-of-denmark-23.jpg",
                            nombreObra = "Hamlet",
                            recientes = true,
                            ultimasSesiones = false,
                            valoracionObra = 4.5
                        },
                        new
                        {
                            idObra = 6,
                            aclamadas = false,
                            autorObra = "Manu Pilas y Gerónimo Raouch",
                            descObra = "Misterio y amor en las catacumbas de París. En los sótanos de la Ópera de París se esconde un misterioso personaje que oculta su rostro desfigurado. Este ser acecha por los camerinos y vigila a Christine, una inocente muchacha con gran talento de la que se ha enamorado. A través de un tenebroso y cruel personaje, Erik, atormentado por la deformidad de su rostro y su pasión por la belleza, y de los recovecos de un edificio, la Ópera de París, Leroux nos introduce en el mundo del otro lado del telón.",
                            directorObra = "Federico Bellone",
                            duracionObra = 150,
                            imagen = "https://teatroaranjuez.es/wp-content/uploads/2023/10/el-fantasma-de-la-opera-330x467-1.jpg",
                            nombreObra = "El Fantasma de la Ópera",
                            recientes = true,
                            ultimasSesiones = false,
                            valoracionObra = 4.7999999999999998
                        },
                        new
                        {
                            idObra = 7,
                            aclamadas = true,
                            autorObra = "Rafa Ramos y Jordi Millan",
                            descObra = "Narra los hechos que suceden durante el casamiento de Teseo, duque de Atenas, con Hipólita, reina de las amazonas. Incluye las aventuras de cuatro amantes atenienses y un grupo de seis actores aficionados que son controlados por las hadas que habitan en el bosque donde la mayor parte de la obra tiene lugar.",
                            directorObra = "Marco Carniti",
                            duracionObra = 90,
                            imagen = "https://image.isu.pub/190709204809-9c82f7fce8bb840f1ff3b5631eef637f/jpg/page_1.jpg",
                            nombreObra = "Sueño de una Noche de Verano",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.2000000000000002
                        },
                        new
                        {
                            idObra = 8,
                            aclamadas = false,
                            autorObra = "Francisco Fraguas y Amanda Recacha",
                            descObra = "Don Juan Tenorio es el personaje más célebre del teatro español. La historia de este burlador de mujeres comienza en los días de Carnaval y acaba en el Día de Difuntos. Don Juan es un seductor que se mofa de todos los valores sociales establecidos. Pero su vida cambiará al conocer a doña Inés. Gracias a su amor, el alma de don Juan se salvará de las llamas del infierno.",
                            directorObra = "Pedro Amalio Lopez",
                            duracionObra = 100,
                            imagen = "https://m.media-amazon.com/images/I/61Er0I3cJaL._AC_UF1000,1000_QL80_.jpg",
                            nombreObra = "Don Juan Tenorio",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.2999999999999998
                        },
                        new
                        {
                            idObra = 9,
                            aclamadas = true,
                            autorObra = "Blanca Apilanez y Juan José Otegui",
                            descObra = "El pueblo de Fuente Ovejuna, ya está harto de la crueldad de su señor, que no hace más que fastidiarlos, ya sea reclutando jóvenes para sus guerras, o deshonrando a sus mujeres, y esta es la gota que colma el vaso de su paciencia, así que deciden intervenir y matar al Comendador.",
                            directorObra = "Adolfo Marsillat",
                            duracionObra = 90,
                            imagen = "https://m.media-amazon.com/images/I/418RabpIZVS.jpg",
                            nombreObra = "Fuenteovejuna",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.5
                        },
                        new
                        {
                            idObra = 10,
                            aclamadas = true,
                            autorObra = "Alejandro Centro y Daniel Valdovinos",
                            descObra = "Es una obra humana que refleja el peregrinaje del ser humano en busca de “la Luz”, es el descubrimiento del hombre hacia Dios, con la ayuda de la razón (Virgilio) y de la fe (Beatriz). El poema es una epopeya religiosa que narra con realismo un viaje, es un canto a la humanidad.",
                            directorObra = "Dante",
                            duracionObra = 110,
                            imagen = "https://m.media-amazon.com/images/I/71WJbXGxPdL._AC_UF1000,1000_QL80_.jpg",
                            nombreObra = "La Divina Comedia",
                            recientes = true,
                            ultimasSesiones = false,
                            valoracionObra = 5.0
                        },
                        new
                        {
                            idObra = 11,
                            aclamadas = false,
                            autorObra = "Eduardo Tovar y Virginia Sanchez",
                            descObra = "Argán se cree muy enfermo y no puede vivir sin estar rodeado de médicos. Para conseguir tener uno en su familia que le haga ahorrar la ingente cantidad de dinero que destina a sus curas, medicamentos y potingues, no duda en concertar un matrimonio de conveniencia entre su hija Angélica con el hijo del doctor Diafoirus.",
                            directorObra = "Eva del Palacio",
                            duracionObra = 70,
                            imagen = "https://www.tarambana.net/upload/espectaculos/foto_poster-1296.jpg?id=117364",
                            nombreObra = "El enfermo imaginario",
                            recientes = false,
                            ultimasSesiones = false,
                            valoracionObra = 4.7000000000000002
                        },
                        new
                        {
                            idObra = 12,
                            aclamadas = true,
                            autorObra = "Tailor Swoft y Jason Derulo",
                            descObra = "Esta obra musical es una de las más célebres de Broadway. Fue creada por el legendario Andrew Lloyd Weber, quien a su vez se basó en los poemas de T. S. Eliot, «El libro de los gatos habilidosos del viejo Possum». Relata la historia de los Jellicle Cats, un grupo de gatos callejeros que poco a poco se va presentando ante el público, en medio de impresionantes números musicales.",
                            directorObra = "Trevor Nunn",
                            duracionObra = 120,
                            imagen = "https://upload.wikimedia.org/wikipedia/en/3/30/Cats_1998_DVD_Cover.jpg",
                            nombreObra = "Cats",
                            recientes = true,
                            ultimasSesiones = false,
                            valoracionObra = 4.2999999999999998
                        },
                        new
                        {
                            idObra = 13,
                            aclamadas = false,
                            autorObra = "Arianna Grande y Adam James",
                            descObra = "Narra la historia de Elphaba, una niña nacida de color verde y cómo se convierte en la Malvada Bruja del Oeste, pasando por los sucesos que experimenta desde su nacimiento, infancia y juventud en la Universidad de Shiz hasta llegar a la edad adulta, momento de la llegada de Dorothy a la tierra de Oz.",
                            directorObra = "Joe Mantello",
                            duracionObra = 165,
                            imagen = "https://m.media-amazon.com/images/M/MV5BNjczYjBhMTctYTA3Yy00NTgyLWFkZWQtZjQwYTRkMDc1YTc1XkEyXkFqcGdeQXVyNTk5NTQzNDI@._V1_.jpg",
                            nombreObra = "Wicked",
                            recientes = false,
                            ultimasSesiones = true,
                            valoracionObra = 4.7000000000000002
                        },
                        new
                        {
                            idObra = 14,
                            aclamadas = true,
                            autorObra = "Miguel del Arco y Gemma Castaño",
                            descObra = "Es la historia de Jean Valjean, un convicto que estuvo injustamente encarcelado por 19 años por haberse robado una rebanada de pan. Al ser liberado de su injusta condena, Valjean trata de escapar de su pasado, lleno de maldad y depravación, para vivir una vida digna y honesta.",
                            directorObra = "David White",
                            duracionObra = 210,
                            imagen = "https://m.media-amazon.com/images/I/517Cb2FS4qL.jpg",
                            nombreObra = "Los Miserables",
                            recientes = false,
                            ultimasSesiones = true,
                            valoracionObra = 4.7999999999999998
                        },
                        new
                        {
                            idObra = 15,
                            aclamadas = false,
                            autorObra = " Nayra Calvo y Miguel A.Luengo",
                            descObra = "En Casa de muñecas Ibsen aborda el problema de la situación de la mujer de la pequeña burguesía en la sociedad de su tiempo. Nora, la protagonista, es el retrato de las mujeres de su clase y puede ofrecer un retrato con mucha actualidad para las mujeres inmersas en la vorágine del mundo contemporáneo.",
                            directorObra = "Franco Zeffirelli",
                            duracionObra = 100,
                            imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/ef/99/ef9995dc7f336bc670c2775b7316b143.jpg",
                            nombreObra = "Casa de Muñecas",
                            recientes = false,
                            ultimasSesiones = true,
                            valoracionObra = 4.5999999999999996
                        },
                        new
                        {
                            idObra = 16,
                            aclamadas = true,
                            autorObra = " Carmelo Gomez y Joaquin Notario",
                            descObra = "En el alcalde de Zalamea, se cuenta la venganza del Alcalde Pedro Crespo, que da muerte a don Álvaro, el arrogante capitán que ha secuestrado a su hija. Esta reacción no se percibe como el resultado de aplicar un código rígido y bárbaro, sino como una reacción justa que será aprobada por el rey.",
                            directorObra = "Miguel Nieto",
                            duracionObra = 90,
                            imagen = "https://m.media-amazon.com/images/I/51fM26seM-L.jpg",
                            nombreObra = "El alcalde de Zalamea",
                            recientes = false,
                            ultimasSesiones = true,
                            valoracionObra = 4.0999999999999996
                        });
                });

            modelBuilder.Entity("ActuArte.Models.Usuarios", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            idUsuario = 1,
                            nombreUsuario = "admin",
                            passwordUsuario = "admin"
                        },
                        new
                        {
                            idUsuario = 2,
                            nombreUsuario = "admin2",
                            passwordUsuario = "admin"
                        },
                        new
                        {
                            idUsuario = 3,
                            nombreUsuario = "admin3",
                            passwordUsuario = "admin"
                        },
                        new
                        {
                            idUsuario = 4,
                            nombreUsuario = "admin4",
                            passwordUsuario = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

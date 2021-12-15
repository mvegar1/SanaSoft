using SanaProducts.Domain.Entities;
using SanaProducts.Domain.Enums;
using SanaProducts.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Data.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SanaProductsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
            {
                new Category{Name="Shoes", Description="Tennis, Boots, Shoes, Sneakers"},
                new Category{Name="Clothes", Description="Shirts, jackets, pants, shorts, socks, hats"},
                new Category{Name="Electronic Devices", Description="TV, Refrigerators, Washing Machines, Cameras, Screens, Computers "},
                new Category{Name="Home", Description="Pictures, wardrobes, tables, chairs, plates, bowls, sofas, rugs, home accessories "},
                new Category{Name="Construction", Description="Hammers, drills, shovels, pliers, screwdrivers, cement, plastic stucco "},
                new Category{Name="Cars", Description="Vehicles, vans, trucks"},
                new Category{Name="Toys", Description="Board games, construction, skill, educational, group or cooperative toys"},
                new Category{Name="Sports", Description="Balls, weights, bars, sports uniforms, sports equipment"},
                new Category{Name="Kids", Description="Clothes, games, toys, instruments "},
                new Category{Name="Video Games", Description="Video game consoles, controls, discs, console accessories, gadgets"},
                new Category{Name="Decoration", Description="Wall clocks, plants, tables, shelves, lamps, flowerpots "},
                new Category{Name="Interior Design", Description="Sofas, rugs and carpets, curtains, lights, clocks, paint"},
                new Category{Name="Food and Drinks", Description="Liquors, instant food, vegetables, fruits, soups, nuts, sodas, cookies, cereals, dairy products, meats "},
                new Category{Name="Liqueurs", Description="Beers, drinks, wines, cocktails"}
            };

            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }

            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Name="Reebok Men's Club MEMT Sneaker", TradeMark="Reebok", Image="https://bit.ly/31UV5dJ"},
                new Product{Name="Hurley Women’s Jacket", TradeMark="Hurley Women’s Jacket", Image="https://bit.ly/3pWYmRB"},
                new Product{Name="Barbie Dreamhouse", TradeMark="Barbie Mattel", Image="https://bit.ly/3s9ejap"},
                new Product{Name="Renault LOGAN", TradeMark="Renault", Image="https://bit.ly/3s1DgnQ"},
                new Product{Name="Lámpara de Techo Metal 21 cm", TradeMark="CasaIdeas", Image="https://bit.ly/3ER8OAx"},
                new Product{Name="Ron Santafe Nido Cóndores", TradeMark="Ron Santafe", Image="https://bit.ly/3mo8hPx"},
                new Product{Name="Microsoft XBOX 360 Slim", TradeMark="Microsoft", Image="https://bit.ly/33g8UDN"},
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();

            var productCategories = new ProductCategory[]
            {
                new ProductCategory{ProductId=1, CategoryId=1 },
                new ProductCategory{ProductId=2, CategoryId=2 },
                new ProductCategory{ProductId=3, CategoryId=7 },
                new ProductCategory{ProductId=4, CategoryId=6 },
                new ProductCategory{ProductId=3, CategoryId=11 },
                new ProductCategory{ProductId=3, CategoryId=12 },
                new ProductCategory{ProductId=2, CategoryId=13 },
                new ProductCategory{ProductId=2, CategoryId=14 },
                new ProductCategory{ProductId=1, CategoryId=3 },
                new ProductCategory{ProductId=1, CategoryId=7 },
                new ProductCategory{ProductId=1, CategoryId=10 }
            };
            foreach (ProductCategory pc in productCategories)
            {
                context.ProductCategories.Add(pc);
            }

            context.SaveChanges();

            var productDetails = new ProductDetail[]
            {
                new ProductDetail{
                    ProductId=7,
                    ProducedBy="Reebok",
                    TechnicalDataSheet="Leather and mesh upper  "+
                                       "Soft, breathable, supportive feel; Low - cut design for mobility  "+
                                       "Removable padded EVA foam sockliner adds lightweight comfort and accommodates orthotics  "+
                                       "High - abrasion - resistant rubber outsole adds durable responsiveness",
                    Model="FU6816",
                    Description="Fresh from the past. Throwback tennis-inspired style gives these men's shoes a legit look. A clean design with etched lines on the midsole and a Union Jack logo keep these triple white kicks smooth. The upper mixes soft leather and airy mesh for a low-key vibe.",
                    Score=5,
                    Gender=Gender.Unisex},
                new ProductDetail{
                    ProductId=6,
                    ProducedBy="Hurley",
                    TechnicalDataSheet="80% cotton, 20% nylon. "+
                    "Machine wash, tumble dry. "+
                    "Sherpa collar and hood. "+
                    "Imported.",
                    Model="20215844DF",
                    Description="This jacket is so cozy, but the only thing keeping it from a 5-star rating is that the sleeves are about 2 inches too short for a typical medium size.",
                    Score=5,
                    Gender=Gender.Female},
                new ProductDetail{
                    ProductId=5,
                    ProducedBy="Barbie Mattel",
                    TechnicalDataSheet="The Barbie® DreamHouse™ measures an impressive 3+ feet tall and 4+ feet wide and features 3 stories, 8 rooms and 70+ accessories."+
                    "Special amenities include a working elevator, home office, carport and second-story pool — fill it with water for a real splash!"+
                    "Lights and sounds add delightful touches, while 2 -in-1 transforming furniture pieces expand the storytelling possibilities."+
                    "The plug-and - play design helps keep pieces in place as small hands move around(and makes cleanup easy for adult hands).",
                    Model="Barbie® DreamHouse™",
                    Description="With so many exciting features and accessories, the Barbie® DreamHouse™ encourages young imaginations to move into this dollhouse and set up a dream home. Kids will have limitless ways to play and explore, from friend sleepovers and family bonding moments to birthday parties and backyard BBQs",
                    Score=4,
                    Gender=Gender.Female},
                new ProductDetail{
                    ProductId=4,
                    ProducedBy="Renault",
                    TechnicalDataSheet="Conduce con estilo. La parrilla frontal negra del Renault LOGAN resalta los faros diurnos con tecnología LED que brindan más visibilidad en la conducción y le dan un mayor estilo. En su versión INTENS, cuenta con rines de 16” diamantados, así como con unos ensanchadores laterales que le permiten al Renault LOGAN tener un diseño más robusto, y un toque Premium en su interior con una cojinería en cuero / TEP.  "+
                    "Seguridad en tu camino El Renault LOGAN está equipado de serie con 4 airbags (conductor, copiloto y laterales), frenos ABS, fijaciones ISOFIX® en los dos puestos laterales traseros y cinturones de seguridad de 3 puntos en todos los puestos. Y a partir de la versión Life+, se suman el control de estabilidad (ESC) y control de tracción (ASR).",
                    Model="Renault LOGAN",
                    Description="LOGAN reinventa su estilo. La parrilla frontal negra resalta sus faros diurnos con tecnología LED brindando más visibilidad y le dan un mayor estilo.​",
                    Score=3,
                    Gender=Gender.Others},
                new ProductDetail{
                    ProductId=3,
                    ProducedBy="CasaIdeas",
                    TechnicalDataSheet="PANTALLA: ALTO 14,5 CM | DIÁMETRO 21 CM  "+
                    "LÁMPARA COMPLETA: ALTO 168,5 CM | DIÁMETRO 21 CM "+
                    "VOLTAJE: 110V "+
                    "WATTS: 40W "+
                    "LONGITUD CABLE: 154 CM / APROX.",
                    Model="3220944000011",
                    Description="LÁMPARA DE TECHO METAL ELECTROPINTADO TERMINACIÓN MATE. TIPO BOMBILLA: E27",
                    Score=4,
                    Gender=Gender.Others},
                new ProductDetail{
                    ProductId=2,
                    ProducedBy="Ron Santafe",
                    TechnicalDataSheet="Su añejamiento durante 8 años en barriles de roble americano le otorga un bouquet amaderado con un equilibrado y agradable sabor, que lo hacen ideal para el consumo puro principalmente. Nace en el 2012 como edición de homenaje a Cundinamarca, su añejamiento durante 12 años le otorga un color ámbar brillante bouquet a roble con toques de vainilla y tostado.",
                    Model="RONSANTAFE2012",
                    Description="Ron SantaFe añejo es la referencia con la que nace la marca. Su fórmula equilibrada le da versatilidad para consumirse tanto puro como mezclado.",
                    Score=3.5,
                    Gender=Gender.Others},
                new ProductDetail{
                    ProductId=1,
                    ProducedBy="Microsoft",
                    TechnicalDataSheet="Incluye control inalámbrico. "+
                    "Resolución de 1920px x 1080px. "+
                    "Memoria RAM de 512MB. "+
                    "Horas de diversión garantizada. "+
                    "Cuenta con: 1 cable hdmi, 1 cable av, 1 cable de alimentación ca.",
                    Model="Microsoft Xbox 360 Slim 250GB",
                    Description="Con tu consola Xbox 360 tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ",
                    Score=4,
                    Gender=Gender.Others}
            };

            foreach (ProductDetail pd in productDetails)
            {
                context.ProductDetails.Add(pd);
            }

            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer{DocumentType=DocumentType.CC, Document="1026287404",Name="Kinley",LastName="Ellis",BirthDate=Convert.ToDateTime("1/04/1985"),Gender=Gender.Masculine},
                new Customer{DocumentType=DocumentType.CC, Document="1026295504",Name="Shiloh",LastName="Adams",BirthDate=Convert.ToDateTime("13/03/1990"),Gender=Gender.Masculine},
                new Customer{DocumentType=DocumentType.CC, Document="1069852236",Name="Ryker",LastName="Fitzpatrick",BirthDate=Convert.ToDateTime("15/12/1994"),Gender=Gender.Masculine},
                new Customer{DocumentType=DocumentType.CC, Document="1058742563",Name="Emilee",LastName="Kennedy",BirthDate=Convert.ToDateTime("3/08/1999"),Gender=Gender.Female},
                new Customer{DocumentType=DocumentType.CC, Document="1014895669",Name="Annabella",LastName="Haley",BirthDate=Convert.ToDateTime("11/04/1978"),Gender=Gender.Female},
                new Customer{DocumentType=DocumentType.CC, Document="1025488856",Name="Tyshawn",LastName="Burch",BirthDate=Convert.ToDateTime("25/12/1991"),Gender=Gender.NonBinary},
                new Customer{DocumentType=DocumentType.CE, Document="UR98556962",Name="Carlos",LastName="Buitrago",BirthDate=Convert.ToDateTime("7/07/1992"),Gender=Gender.Masculine},
                new Customer{DocumentType=DocumentType.CE, Document="MU9658442",Name="Bianca",LastName="Brock",BirthDate=Convert.ToDateTime("30/03/1989"),Gender=Gender.NonBinary},
                new Customer{DocumentType=DocumentType.PA, Document="ES4855569S204",Name="Jocelynn",LastName="Cochran",BirthDate=Convert.ToDateTime("14/06/1978"),Gender=Gender.Female},
                new Customer{DocumentType=DocumentType.PA, Document="JUS585695014S",Name="Messiah",LastName="Howe",BirthDate=Convert.ToDateTime("14/08/1968"),Gender=Gender.Masculine}
            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();

            var customerDetails = new CustomerDetail[]
           {
                new CustomerDetail{CustomerId=1, Phone1="3104805092",Phone2="3106837210",Email1="Messiah@mail.com",Email2="Howe@mail.com",FullAddress1="Carrera 22 No. 17-31",FullAddress2="Calle 59 No. 27 - 35 Barrio Galán"},
                new CustomerDetail{CustomerId=2, Phone1="3112719041",Phone2="3112688640",Email1="Jocelynn@mail.com",Email2="Cochran@mail.com",FullAddress1="Calle 59 No. 27 - 35 Barrio Galán",FullAddress2="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406"},
                new CustomerDetail{CustomerId=3, Phone1="3121944314",Phone2="3126227884",Email1="Bianca@mail.com",Email2="Brock@mail.com",FullAddress1="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406",FullAddress2="Calle 33B  No. 38 - 42  Barrio Barzal"},
                new CustomerDetail{CustomerId=4, Phone1="3133274793",Phone2="3136091439",Email1="Carlos@mail.com",Email2="Buitrago@mail.com",FullAddress1="Calle 33B  No. 38 - 42  Barrio Barzal",FullAddress2="Calle 15 No. 9 - 56 centro"},
                new CustomerDetail{CustomerId=5, Phone1="3148478304",Phone2="3142374470",Email1="Tyshawn@mail.com",Email2="Burch@mail.com",FullAddress1="Calle 15 No. 9 - 56 centro",FullAddress2="CARRERA 42 No.5C-48 Barrio Tequendama"},
                new CustomerDetail{CustomerId=6, Phone1="3152262776",Phone2="3154961367",Email1="Annabella@mail.com",Email2="Haley@mail.com",FullAddress1="CARRERA 42 No.5C-48 Barrio Tequendama",FullAddress2="CALLE 23 No. 12-11"},
                new CustomerDetail{CustomerId=7, Phone1="3167131283",Phone2="3169077813",Email1="Emilee@mail.com",Email2="Kennedy@mail.com",FullAddress1="CALLE 23 No. 12-11",FullAddress2="Carrera 23  No. 10A - 10"},
                new CustomerDetail{CustomerId=8, Phone1="3179703900",Phone2="3171365766",Email1="Ryker@mail.com",Email2="Fitzpatrick@mail.com",FullAddress1="Carrera 23  No. 10A - 10",FullAddress2="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304"},
                new CustomerDetail{CustomerId=9, Phone1="3187771726",Phone2="3189344142",Email1="Shiloh@mail.com",Email2="Adams@mail.com",FullAddress1="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304",FullAddress2="Carrera 3  con Calle 28 Esquina Barrio Claret"},
                new CustomerDetail{CustomerId=10, Phone1="3194221080",Phone2="3193877558",Email1="Kinley@mail.com",Email2="Ellis@mail.com",FullAddress1="Carrera 3  con Calle 28 Esquina Barrio Claret",FullAddress2=""}

           };

            foreach (CustomerDetail cd in customerDetails)
            {
                context.CustomerDetails.Add(cd);
            }

            context.SaveChanges();

            var orders = new Order[]
           {
               new Order{CustomerId=1, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Carrera 22 No. 17-31",AddressType=AddressType.Home,PostalCode="Carrera 22 No. 17-31",AdditionalInformation=""},
               new Order{CustomerId=2, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 59 No. 27 - 35 Barrio Galán",AddressType=AddressType.Home,PostalCode="Calle 59 No. 27 - 35 Barrio Galán",AdditionalInformation=""},
               new Order{CustomerId=3, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406",AddressType=AddressType.Home,PostalCode="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406",AdditionalInformation=""},
               new Order{CustomerId=4, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 33B  No. 38 - 42  Barrio Barzal",AddressType=AddressType.Home,PostalCode="Calle 33B  No. 38 - 42  Barrio Barzal",AdditionalInformation=""},
               new Order{CustomerId=5, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="Calle 15 No. 9 - 56 centro",AddressType=AddressType.Home,PostalCode="Calle 15 No. 9 - 56 centro",AdditionalInformation=""},
               new Order{CustomerId=6, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="CARRERA 42 No.5C-48 Barrio Tequendama",AddressType=AddressType.Home,PostalCode="CARRERA 42 No.5C-48 Barrio Tequendama",AdditionalInformation=""},
               new Order{CustomerId=7, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="CALLE 23 No. 12-11",AddressType=AddressType.Home,PostalCode="CALLE 23 No. 12-11",AdditionalInformation=""},
               new Order{CustomerId=8, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Carrera 23  No. 10A - 10",AddressType=AddressType.Home,PostalCode="Carrera 23  No. 10A - 10",AdditionalInformation=""},
               new Order{CustomerId=9, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304",AddressType=AddressType.Home,PostalCode="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304",AdditionalInformation=""},
               new Order{CustomerId=10, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Carrera 3  con Calle 28 Esquina Barrio Claret",AddressType=AddressType.Home,PostalCode="Carrera 3  con Calle 28 Esquina Barrio Claret",AdditionalInformation=""},
               new Order{CustomerId=1, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Carrera 22 No. 17-31",AddressType=AddressType.Home,PostalCode="Carrera 22 No. 17-31",AdditionalInformation=""},
               new Order{CustomerId=2, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 59 No. 27 - 35 Barrio Galán",AddressType=AddressType.Home,PostalCode="Calle 59 No. 27 - 35 Barrio Galán",AdditionalInformation=""},
               new Order{CustomerId=3, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406",AddressType=AddressType.Home,PostalCode="Calle 12 No. 4 - 19  Edificio Panamericano Of. 406",AdditionalInformation=""},
               new Order{CustomerId=4, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="BOGOTÁ",City="BOGOTÁ",FullAddress="Calle 33B  No. 38 - 42  Barrio Barzal",AddressType=AddressType.Home,PostalCode="Calle 33B  No. 38 - 42  Barrio Barzal",AdditionalInformation=""},
               new Order{CustomerId=5, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="Calle 15 No. 9 - 56 centro",AddressType=AddressType.Home,PostalCode="Calle 15 No. 9 - 56 centro",AdditionalInformation=""},
               new Order{CustomerId=6, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="CARRERA 42 No.5C-48 Barrio Tequendama",AddressType=AddressType.Home,PostalCode="CARRERA 42 No.5C-48 Barrio Tequendama",AdditionalInformation=""},
               new Order{CustomerId=7, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="ANTIOQUIA",City="MEDELLÍN",FullAddress="CALLE 23 No. 12-11",AddressType=AddressType.Home,PostalCode="CALLE 23 No. 12-11",AdditionalInformation=""},
               new Order{CustomerId=8, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Carrera 23  No. 10A - 10",AddressType=AddressType.Home,PostalCode="Carrera 23  No. 10A - 10",AdditionalInformation=""},
               new Order{CustomerId=9, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304",AddressType=AddressType.Home,PostalCode="Avda Francisco Newball No. 4A-20 - Edif. Cámara de Comercio Of. 304",AdditionalInformation=""},
               new Order{CustomerId=10, OrderDate=Convert.ToDateTime("13/12/2021"),ShippedDate=Convert.ToDateTime("16/12/2021"),Country="COLOMBIA",State="VALLE DEL CAUCA",City="CALI",FullAddress="Carrera 3  con Calle 28 Esquina Barrio Claret",AddressType=AddressType.Home,PostalCode="Carrera 3  con Calle 28 Esquina Barrio Claret",AdditionalInformation=""}

           };

            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }

            context.SaveChanges();

            var orderDetails = new OrderDetail[]
            {
                new OrderDetail{OrderId=6, ProductId=1,UnitPrice=750000,Quantity=2},
                new OrderDetail{OrderId=7, ProductId=2,UnitPrice=85000,Quantity=20},
                new OrderDetail{OrderId=8, ProductId=3,UnitPrice=25000,Quantity=140},
                new OrderDetail{OrderId=1, ProductId=4,UnitPrice=65000000,Quantity=1},
                new OrderDetail{OrderId=5, ProductId=5,UnitPrice=684300,Quantity=3},
                new OrderDetail{OrderId=4, ProductId=6,UnitPrice=247500,Quantity=9},
                new OrderDetail{OrderId=3, ProductId=7,UnitPrice=124999,Quantity=2},
                new OrderDetail{OrderId=2, ProductId=1,UnitPrice=750000,Quantity=6},
                new OrderDetail{OrderId=19, ProductId=2,UnitPrice=85000,Quantity=100},
                new OrderDetail{OrderId=20, ProductId=3,UnitPrice=25000,Quantity=30},
                new OrderDetail{OrderId=16, ProductId=4,UnitPrice=65000000,Quantity=2},
                new OrderDetail{OrderId=17, ProductId=5,UnitPrice=684300,Quantity=5},
                new OrderDetail{OrderId=18, ProductId=6,UnitPrice=247500,Quantity=63},
                new OrderDetail{OrderId=9, ProductId=7,UnitPrice=124999,Quantity=4},
                new OrderDetail{OrderId=10, ProductId=1,UnitPrice=750000,Quantity=8},
                new OrderDetail{OrderId=11, ProductId=2,UnitPrice=85000,Quantity=45},
                new OrderDetail{OrderId=12, ProductId=3,UnitPrice=25000,Quantity=35},
                new OrderDetail{OrderId=13, ProductId=4,UnitPrice=65000000,Quantity=6},
                new OrderDetail{OrderId=14, ProductId=5,UnitPrice=684300,Quantity=7},
                new OrderDetail{OrderId=15, ProductId=6,UnitPrice=247500,Quantity=20},
                new OrderDetail{OrderId=6, ProductId=7,UnitPrice=124999,Quantity=1},
                new OrderDetail{OrderId=7, ProductId=1,UnitPrice=750000,Quantity=5},
                new OrderDetail{OrderId=8, ProductId=2,UnitPrice=85000,Quantity=20},
                new OrderDetail{OrderId=1, ProductId=3,UnitPrice=25000,Quantity=400},
                new OrderDetail{OrderId=5, ProductId=4,UnitPrice=65000000,Quantity=5},
                new OrderDetail{OrderId=4, ProductId=5,UnitPrice=684300,Quantity=1},
                new OrderDetail{OrderId=3, ProductId=6,UnitPrice=247500,Quantity=13},
                new OrderDetail{OrderId=2, ProductId=7,UnitPrice=124999,Quantity=89},
                new OrderDetail{OrderId=19, ProductId=1,UnitPrice=750000,Quantity=9},
                new OrderDetail{OrderId=20, ProductId=2,UnitPrice=85000,Quantity=1},
                new OrderDetail{OrderId=16, ProductId=3,UnitPrice=25000,Quantity=3},
                new OrderDetail{OrderId=17, ProductId=4,UnitPrice=65000000,Quantity=4},
                new OrderDetail{OrderId=18, ProductId=5,UnitPrice=684300,Quantity=3},
                new OrderDetail{OrderId=9, ProductId=6,UnitPrice=247500,Quantity=9},
                new OrderDetail{OrderId=10, ProductId=7,UnitPrice=124999,Quantity=4},
                new OrderDetail{OrderId=11, ProductId=1,UnitPrice=750000,Quantity=10},
                new OrderDetail{OrderId=12, ProductId=2,UnitPrice=85000,Quantity=65},
                new OrderDetail{OrderId=13, ProductId=3,UnitPrice=25000,Quantity=180},
                new OrderDetail{OrderId=14, ProductId=4,UnitPrice=65000000,Quantity=1},
                new OrderDetail{OrderId=15, ProductId=5,UnitPrice=684300,Quantity=9}
            };

            foreach (OrderDetail od in orderDetails)
            {
                context.OrderDetails.Add(od);
            }

            context.SaveChanges();
        }
    }
}

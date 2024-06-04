using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Infrastructure.Configurations;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CharacterConfiguration());
        modelBuilder.ApplyConfiguration(new LevelConfiguration());

        modelBuilder.Entity<ItemDataModel>()
            .HasDiscriminator<EItemType>("ItemType")
            .HasValue<WeaponDataModel>(EItemType.Weapon)
            .HasValue<PotionDataModel>(EItemType.Potion)
            //.HasValue<ItemDataModel>(EItemType.Armor)
            //.HasValue<ItemDataModel>(EItemType.Tool)
            .HasValue<ItemDataModel>(EItemType.Miscellaneous);

        #region Items

        #region Weapons

        modelBuilder.Entity<WeaponDataModel>().HasData(
            new WeaponDataModel(1, EDamageType.Piercing, 4, "Adaga", "Armas Simples Corpo-a-Corpo", 2,
                ECurrencyType.Gold, 0.5),
            new WeaponDataModel(1, EDamageType.Piercing, 6, "Azagaia", "Armas Simples Corpo-a-Corpo", 5,
                ECurrencyType.Silver, 1.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 6, "Bordão", "Armas Simples Corpo-a-Corpo", 2,
                ECurrencyType.Silver, 2.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 8, "Clava Grande", "Armas Simples Corpo-a-Corpo", 2,
                ECurrencyType.Silver, 5.0),
            new WeaponDataModel(1, EDamageType.Slashing, 4, "Foice Curta", "Armas Simples Corpo-a-Corpo", 1,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 6, "Maça", "Armas Simples Corpo-a-Corpo", 5,
                ECurrencyType.Gold, 2.0),
            new WeaponDataModel(1, EDamageType.Slashing, 6, "Machadinha", "Armas Simples Corpo-a-Corpo", 5,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 4, "Martelo Leve", "Armas Simples Corpo-a-Corpo", 2,
                ECurrencyType.Gold, 2.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 4, "Porrete", "Armas Simples Corpo-a-Corpo", 1,
                ECurrencyType.Silver, 1.0),

            new WeaponDataModel(1, EDamageType.Piercing, 6, "Arco Curto", "Armas Simples à Distância", 25,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Piercing, 8, "Besta Leve", "Armas Simples à Distância", 25,
                ECurrencyType.Gold, 2.5),
            new WeaponDataModel(1, EDamageType.Piercing, 4, "Dardo", "Armas Simples à Distância", 5,
                ECurrencyType.Copper, 0.1),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 4, "Funda", "Armas Simples à Distância", 1,
                ECurrencyType.Silver, 0.0),

            new WeaponDataModel(1, EDamageType.Slashing, 10, "Alabarda", "Armas Marciais Corpo-a-Corpo", 20,
                ECurrencyType.Gold, 3.0),
            new WeaponDataModel(1, EDamageType.Slashing, 6, "Cimitarra", "Armas Marciais Corpo-a-Corpo", 25,
                ECurrencyType.Gold, 1.5),
            new WeaponDataModel(1, EDamageType.Slashing, 4, "Chicote", "Armas Marciais Corpo-a-Corpo", 2,
                ECurrencyType.Gold, 1.5),
            new WeaponDataModel(1, EDamageType.Slashing, 6, "Espada Curta", "Armas Marciais Corpo-a-Corpo", 10,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(2, EDamageType.Slashing, 6, "Espada Grande", "Armas Marciais Corpo-a-Corpo", 50,
                ECurrencyType.Gold, 3.0),
            new WeaponDataModel(1, EDamageType.Slashing, 8, "Espada Longa", "Armas Marciais Corpo-a-Corpo", 15,
                ECurrencyType.Gold, 1.5),
            new WeaponDataModel(1, EDamageType.Slashing, 10, "Glaive", "Armas Marciais Corpo-a-Corpo", 20,
                ECurrencyType.Gold, 3.0),
            new WeaponDataModel(1, EDamageType.Piercing, 12, "Lança de Montaria", "Armas Marciais Corpo-a-Corpo", 10,
                ECurrencyType.Gold, 3.5),
            new WeaponDataModel(1, EDamageType.Piercing, 10, "Lança Longa", "Armas Marciais Corpo-a-Corpo", 5,
                ECurrencyType.Gold, 4.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 8, "Maça Estrela", "Armas Marciais Corpo-a-Corpo", 15,
                ECurrencyType.Gold, 2.0),
            new WeaponDataModel(1, EDamageType.Slashing, 10, "Machado Grande", "Armas Marciais Corpo-a-Corpo", 30,
                ECurrencyType.Gold, 3.5),
            new WeaponDataModel(1, EDamageType.Slashing, 8, "Machado de Batalha", "Armas Marciais Corpo-a-Corpo", 10,
                ECurrencyType.Gold, 2.0),
            new WeaponDataModel(2, EDamageType.Bludgeoning, 6, "Malho", "Armas Marciais Corpo-a-Corpo", 10,
                ECurrencyType.Gold, 5.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 8, "Mangual", "Armas Marciais Corpo-a-Corpo", 10,
                ECurrencyType.Gold, 2.0),
            new WeaponDataModel(1, EDamageType.Bludgeoning, 8, "Martelo de Guerra", "Armas Marciais Corpo-a-Corpo", 15,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Piercing, 8, "Picareta de Guerra", "Armas Marciais Corpo-a-Corpo", 5,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Piercing, 8, "Rapieira", "Armas Marciais Corpo-a-Corpo", 25,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Piercing, 6, "Tridente", "Armas Marciais Corpo-a-Corpo", 5,
                ECurrencyType.Gold, 2.0),


            new WeaponDataModel(1, EDamageType.Piercing, 8, "Arco Longo", "Armas Marciais à Distância", 50,
                ECurrencyType.Gold, 1.0),
            new WeaponDataModel(1, EDamageType.Piercing, 6, "Besta de Mão", "Armas Marciais à Distância", 75,
                ECurrencyType.Gold, 1.5),
            new WeaponDataModel(1, EDamageType.Piercing, 10, "Besta Pesada", "Armas Marciais à Distância", 50,
                ECurrencyType.Gold, 4.5),
            new WeaponDataModel(0, EDamageType.Piercing, 1, "Rede", "Armas Marciais à Distância", 1,
                ECurrencyType.Gold, 1.5),
            new WeaponDataModel(1, EDamageType.Piercing, 1, "Zarabatana", "Armas Marciais à Distância", 10,
                ECurrencyType.Gold, 0.5)
        );

        #endregion

        #region Miscellaneous

        modelBuilder.Entity<ItemDataModel>().HasData(
            new ItemDataModel("Ábaco", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Ácido (vidro)", "", EItemType.Miscellaneous, 25, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Água benta (frasco)", """
                                                     Usando uma ação, você pode espalhar o 
                                                     conteúdo desse frasco em uma criatura a até 1,5 metro de 
                                                     você ou arremessar a até 6 metros, quebrando o frasco 
                                                     com o impacto. Em ambos os casos, você deve realizar um 
                                                     ataque à distância contra uma criatura alvo, tratando a 
                                                     água benta como uma arma improvisada. Se o alvo for um 
                                                     corruptor ou morto-vivo, ele sofre 2d6 de dano radiante. 
                                                     """, EItemType.Miscellaneous, 25, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Algemas", """
                                          Essas algemas de metal podem prender 
                                         uma criatura Pequena ou Média. Escapar das algemas 
                                         exige sucesso em um teste de Destreza CD 20. Quebrá-las 
                                         exige um teste de Força CD 20 bem sucedido. Cada 
                                         conjunto de algemas vem com uma chave. Sem a chave, 
                                         uma criatura proficiente com ferramentas de ladrão pode 
                                         abrir a fechadura das algemas com um sucesso em um 
                                         teste de Destreza CD 15. As algemas têm 15 pontos de 
                                         vida. 
                                         """, EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Algibeira", """
                                           Uma bolsa de pano ou couro que pode 
                                           armazenar até 20 munições de funda ou 50 munições de 
                                           zarabatana, entre outras coisas. Para armazenar 
                                           componentes de magia, veja bolsa de componentes, 
                                           também descrita nessa seção.
                                           """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Aljava", """
                                        Uma aljava pode guardar até 20 flechas.
                                        """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Ampulheta", "", EItemType.Miscellaneous, 25, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Antídoto (vidro)", """
                                                  Uma criatura que beber o líquido desse 
                                                  vidro tem vantagem em testes de resistência contra 
                                                  venenos por 1 hora. O antídoto não confere nenhum 
                                                  benefício para mortos-vivos ou constructos. 
                                                  """, EItemType.Miscellaneous, 50, ECurrencyType.Gold, 0),
            new ItemDataModel("Apito de advertência", "", EItemType.Miscellaneous, 25, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Ariete portátil", """
                                                  Você pode usar um aríete portátil 
                                                 para quebrar portas. Ao fazer isso, você ganha um bônus 
                                                 de +4 no teste de Força. Outra criatura pode ajudá-lo a 
                                                 usar o aríete, o que concede vantagem no teste.
                                                 """, EItemType.Miscellaneous, 4, ECurrencyType.Gold, 17.5),
            new ItemDataModel("Armadilha de caça", """
                                                   Quando você usa sua ação para 
                                                   armá-la, essa armadilha forma um anel de aço com 
                                                   dentes serrilhados. Eles se fecham quando uma criatura 
                                                   pisa sobre uma placa de pressão no seu centro. A 
                                                   armadilha é fixada por uma pesada corrente em um 
                                                   objeto fixo e imóvel, como uma árvore ou um cravo 
                                                   enterrado no chão. Uma criatura que pisar na placa de 
                                                   pressão deve ser bem sucedida em um teste de resistência 
                                                   de Destreza CD 13 ou sofrerá 1d4 de dano perfurante e 
                                                   para de se mover. Daí em diante, até que a criatura se 
                                                   liberte da armadilha, seu movimento é limitado ao 
                                                   comprimento da corrente (tipicamente 1 metro de 
                                                   comprimento). A criatura presa pode usar sua ação para 
                                                   fazer um teste de Força CD 13 e se libertar, ou outra 
                                                   criatura no alcance pode fazer o teste para libertá-la. 
                                                   Cada fracasso no teste causa 1 de dano perfurante à 
                                                   criatura presa.
                                                   """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 12.5),
            new ItemDataModel("Arpéu", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Balança de mercador", """
                                                     Trata-se de uma pequena 
                                                     balança, pratos e um sortimento adequado de pesos de até 
                                                     1 kg. Com ela, você pode medir o peso exato de pequenos 
                                                     objetos, como metais preciosos brutos ou bens comerciais, 
                                                     para ajudar a determinar seu valor.
                                                     """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Balde", "", EItemType.Miscellaneous, 5, ECurrencyType.Copper, 1.0),
            new ItemDataModel("Barril", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 35.0),
            new ItemDataModel("Baú", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 12.5),
            new ItemDataModel("Bolsa de componentes", """
                                                      Trata-se de uma pequena 
                                                      bolsa de couro à prova d'água que pode ser fixada em um 
                                                      cinto. Ela possui compartimentos para armazenar todos 
                                                      os componentes materiais e outros itens especiais que 
                                                      você precisa para lançar suas magias, exceto os 
                                                      componentes que possuem um custo específico (conforme 
                                                      indicado na descrição da magia).
                                                      """, EItemType.Miscellaneous, 25, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Caixa de Fogo", """
                                               Esse pequeno recipiente detém uma 
                                               pederneira, isqueiro e um pavio (um pano geralmente 
                                               seco embebido em óleo) usado para acender uma fogueira. 
                                               Usá-lo para acender uma tocha – ou qualquer outra coisa 
                                               exposta a um combustível abundante – leva uma ação. 
                                               Acender qualquer outro fogo leva 1 minuto.
                                               """, EItemType.Miscellaneous, 5, ECurrencyType.Silver, 0.5),
            new ItemDataModel("Caneca", "", EItemType.Miscellaneous, 2, ECurrencyType.Copper, 0.5),
            new ItemDataModel("Caneta tinteiro", "", EItemType.Miscellaneous, 2, ECurrencyType.Copper, 0),
            new ItemDataModel("Cantil", "", EItemType.Miscellaneous, 2, ECurrencyType.Silver, 2.5),
            new ItemDataModel("Cesto", "", EItemType.Miscellaneous, 4, ECurrencyType.Silver, 1.0),
            new ItemDataModel("Cobertor de inverno", "", EItemType.Miscellaneous, 5, ECurrencyType.Silver, 1.5),
            new ItemDataModel("Corda de cânhamo (15 metros)", """
                                                              Tem 2 pontos de vida e pode ser arrebentada com um teste de 
                                                              Força CD 17 bem sucedido.
                                                              """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Corda de seda (15 metros)", """
                                                           Tem 2 pontos de vida e pode ser arrebentada com um teste de 
                                                           Força CD 17 bem sucedido.
                                                           """, EItemType.Miscellaneous, 10, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Corrente (3 metros)", """
                                                     Uma corrente possui 10 pontos de vida e 
                                                     pode ser arrebentada com um teste de Força CD 20 bem 
                                                     sucedido.
                                                     """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Equipamento de pescaria", """
                                                         Este kit inclui uma vara 
                                                         de pesca de madeira, linha de seda, boias de cortiça, 
                                                         anzóis de aço, chumbadas, iscas e redes de pesca.
                                                         """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Escada (3 metros)", "", EItemType.Miscellaneous, 1, ECurrencyType.Silver, 12.5),
            new ItemDataModel("Esferas (sacola com 1.000)", """
                                                            Usando uma ação, você pode 
                                                            despejar essas minúsculas esferas de metal para cobrir a 
                                                            área de um quadrado de 3 metros de lado. A criatura que 
                                                            se mover dentro da área deve ser bem sucedida em um 
                                                            teste de resistência de Destreza CD 10 para não cair no 
                                                            chão. Uma criatura que mover pela área usando metade 
                                                            do seu deslocamento não precisa fazer o teste de 
                                                            resistência.
                                                            """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Espelho de aço", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0.25),
            new ItemDataModel("Estrepes (bolsa com 20)", """
                                                         Usando uma ação, você pode espalhar um 
                                                         único saco de estrepes para cobrir a área de um quadrado 
                                                         de 1,5 metro de lado. Qualquer criatura que entrar na 
                                                         área deve ser bem sucedida em um teste de resistência de 
                                                         Destreza CD 15. Se falhar, para de se mover e sofre 1 de 
                                                         dano perfurante. Até que a criatura recupere pelo menos 
                                                         1 ponto de vida, seu deslocamento de caminhada é 
                                                         reduzido em 3 metros. Uma criatura que se mover pela 
                                                         área usando metade do seu deslocamento não precisa 
                                                         fazer o teste de resistência.
                                                         """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Fechadura", """
                                           A fechadura vem com chave. Sem a 
                                           chave, uma criatura proficiente com ferramentas de 
                                           ladrão pode abrir a fechadura com um sucesso em um 
                                           teste de Destreza CD 15. O Mestre pode decidir que 
                                           fechaduras melhores estão disponíveis por preços mais 
                                           elevados.
                                           """, EItemType.Miscellaneous, 10, ECurrencyType.Gold, 0.5),

            new ItemDataModel("Bastão", "", EItemType.Miscellaneous, 10, ECurrencyType.Gold, 1),
            new ItemDataModel("Cajado", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 2),
            new ItemDataModel("Cristal", "", EItemType.Miscellaneous, 10, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Orbe", "", EItemType.Miscellaneous, 20, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Varinha", "", EItemType.Miscellaneous, 10, ECurrencyType.Gold, 0.5),

            new ItemDataModel("Cajado de madeira", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Ramo de visco", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0),
            new ItemDataModel("Totem", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0),
            new ItemDataModel("Varinha de teixo", "", EItemType.Miscellaneous, 10, ECurrencyType.Gold, 0.5),

            new ItemDataModel("Frasco", "", EItemType.Miscellaneous, 2, ECurrencyType.Copper, 1),
            new ItemDataModel("Garrafa de vidro", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 1),
            new ItemDataModel("Giz (1 peça)", "", EItemType.Miscellaneous, 1, ECurrencyType.Copper, 0),
            new ItemDataModel("Grimório", """
                                          Essencial para os magos, um grimório é 
                                          um volume encadernado em couro com 100 páginas de 
                                          pergaminhos em branco, adequado para armazenar 
                                          magias.
                                          """, EItemType.Miscellaneous, 50, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Jarra", "", EItemType.Miscellaneous, 4, ECurrencyType.Copper, 2.0),
            new ItemDataModel("Kit de escalada", """
                                                 Um kit de escalada inclui pítons 
                                                 especiais, botas com solas pontiagudas, luvas e um cinto. 
                                                 Você pode usar o kit de escalada como uma ação para 
                                                 "ancorar-se". Quando faz isso, você não pode cair mais de 
                                                 7,5 metros a partir do ponto onde se ancorou, e não pode 
                                                 subir mais de 7,5 metros de distância desse ponto, sem 
                                                 desfazer a âncora.
                                                 """, EItemType.Miscellaneous, 25, ECurrencyType.Gold, 6.0),
            new ItemDataModel("Kit de primeiros-socorros", """
                                                           Esse kit é uma bolsa de 
                                                           couro contendo ataduras, pomadas e talas. O kit possui 
                                                           material suficiente para dez usos. Usando uma ação, você 
                                                           pode gastar um uso do kit para estabilizar uma criatura 
                                                           que tenha 0 pontos de vida, sem a necessidade de realizar 
                                                           um teste de Sabedoria (Medicina).
                                                           """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 1.5),


            new ItemDataModel("Lâmpada", """
                                         Uma lâmpada lança luz plena em um raio 
                                         de 4,5 metros e penumbra por mais 9 metros. Uma vez 
                                         acesa, a lâmpada queima por 6 horas usando um frasco de 
                                         óleo (500 ml).
                                         """, EItemType.Miscellaneous, 5, ECurrencyType.Silver, 0.5),
            new ItemDataModel("Lanterna coberta", """
                                                  Uma lanterna coberta lança luz 
                                                  plena em um raio de 9 metros e penumbra por mais 9 
                                                  metros. Uma vez acesa, ela queima por 6 horas usando 
                                                  um frasco de óleo (500 ml). Usando uma ação, você pode 
                                                  abaixar a cobertura, reduzindo a claridade para 
                                                  penumbra em um raio de 1,5 metro.
                                                  """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Lanterna furta-fogo", """
                                                     Uma lanterna furta-fogo 
                                                     lança luz plena em um cone de 18 metros e penumbra por 
                                                     mais 18 metros. Uma vez acesa, ela queima por 6 horas 
                                                     usando um frasco de óleo (500 ml).
                                                     """, EItemType.Miscellaneous, 10, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Lente de aumento", """
                                                  Essa lente permite ver pequenos 
                                                  objetos mais de perto. Ela também é útil como um 
                                                  substituto da pederneira e isqueiro para acender fogo. 
                                                  Usar uma lupa para acender fogo necessita de luz tão 
                                                  brilhante como a luz do sol para focar, um pavio e cerca 
                                                  de 5 minutos. Uma lente de aumento concede vantagem 
                                                  em qualquer teste de habilidade feito para avaliar ou 
                                                  inspecionar um item que é pequeno ou muito detalhado.
                                                  """, EItemType.Miscellaneous, 100, ECurrencyType.Gold, 0),
            new ItemDataModel("Livro", """
                                       Um livro pode conter poesia, relatos históricos, 
                                       informações relativas a um campo particular de 
                                       sabedoria, diagramas e notas sobre engenhocas gnômicas, 
                                       ou qualquer outra coisa que possa ser representada 
                                       usando texto ou imagens.
                                       """, EItemType.Miscellaneous, 25, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Luneta", """
                                        Objetos vistos através de uma luneta são 
                                        ampliados até o dobro do seu tamanho.
                                        """, EItemType.Miscellaneous, 1000, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Manto", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Marreta", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Martelo", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Mochila", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.5),

            new ItemDataModel("Balas de Funda (20)", "", EItemType.Miscellaneous, 4, ECurrencyType.Copper, 0.75),
            new ItemDataModel("Flechas (20)", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Virotes (20)", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.75),
            new ItemDataModel("Zarabatana (50)", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.5),

            new ItemDataModel("Óleo (frasco)", """
                                               Geralmente vem em um frasco de argila que 
                                               contém 500 ml. Usando uma ação, você pode espirrar o 
                                               óleo desse frasco em uma criatura a até 1,5 metro de você
                                               ou arremessar a até 6 metros, quebrando-o com o 
                                               impacto. Você deve realizar um ataque à distância contra 
                                               uma criatura ou objeto, tratando o óleo como uma arma 
                                               improvisada. Com um sucesso, o alvo é coberto de óleo. Se 
                                               o alvo sofrer qualquer dano flamejante antes do óleo secar
                                                (depois de 1 minuto), a criatura sofre 5 de dano 
                                               flamejante adicional pela queima do óleo. Você também 
                                               pode derramar um frasco de óleo no chão para cobrir uma 
                                               área de um quadrado de 1,5 metro de lado, desde que a 
                                               superfície esteja nivelada. Se aceso, o óleo queima por 2 
                                               rodadas e causa 5 de dano flamejante a qualquer criatura 
                                               que entrar na área ou terminar seu turno dentro da área. 
                                               Uma criatura pode sofrer esse dano apenas uma vez por 
                                               turno.
                                               """, EItemType.Miscellaneous, 1, ECurrencyType.Silver, 0.5),
            new ItemDataModel("Pá", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Panela de ferro", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Papel (uma folha)", "", EItemType.Miscellaneous, 2, ECurrencyType.Silver, 0.0),
            new ItemDataModel("Parafina", "", EItemType.Miscellaneous, 5, ECurrencyType.Silver, 0.0),
            new ItemDataModel("Pé de cabra", """
                                             Usar um pé de cabra concede vantagem 
                                             nos testes de Força onde uma alavanca possa ser 
                                             aplicada.
                                             """, EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Pedra de amolar", "", EItemType.Miscellaneous, 1, ECurrencyType.Copper, 0.0),
            new ItemDataModel("Perfume (frasco)", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0.0),
            new ItemDataModel("Pergaminho (uma folha)", "", EItemType.Miscellaneous, 1, ECurrencyType.Silver, 0.0),
            new ItemDataModel("Picareta de minerador", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Piton", "", EItemType.Miscellaneous, 5, ECurrencyType.Copper, 0),
            new ItemDataModel("Porta mapas ou pergaminhos", """
                                                            Esse estojo 
                                                            cilíndrico de couro pode armazenar até 10 folhas de papel 
                                                            enroladas ou 5 folhas de pergaminhos enroladas.
                                                            """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Porta virotes", """
                                               Esse estojo de madeira pode 
                                               armazenar até 20 virotes de besta.
                                               """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Pregos de ferro (10)", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Rações de viagem (1 dia)", """
                                                          Consistem em alimentos desidratados adequados para viagens longas, 
                                                          incluindo carne seca, frutas secas, bolachas e nozes. 
                                                          """, EItemType.Miscellaneous, 5, ECurrencyType.Silver, 1.0),
            new ItemDataModel("Robes", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Roldana e polia", """
                                                 Um conjunto de roldanas com um 
                                                 cabo entre elas e um gancho para fixar aos objetos, a 
                                                 roldana e polia permitem içar até quatro vezes o peso que 
                                                 você ergueria normalmente.
                                                 """, EItemType.Miscellaneous, 1, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Roupas comuns", "", EItemType.Miscellaneous, 5, ECurrencyType.Silver, 1.5),
            new ItemDataModel("Roupas de viajante", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Roupas de entretenimento", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 2.0),
            new ItemDataModel("Roupas finas", "", EItemType.Miscellaneous, 15, ECurrencyType.Gold, 3.0),
            new ItemDataModel("Sabão", "", EItemType.Miscellaneous, 2, ECurrencyType.Copper, 0),
            new ItemDataModel("Saco", "", EItemType.Miscellaneous, 1, ECurrencyType.Copper, 0.25),
            new ItemDataModel("Saco de dormir", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 3.5),

            new ItemDataModel("Amuleto", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Emblema", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0),
            new ItemDataModel("Relicário", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 1),

            new ItemDataModel("Sinete", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0),
            new ItemDataModel("Sino", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0),
            new ItemDataModel("Tenda para duas pessoas", """
                                                         Um abrigo simples e portátil que acomoda 
                                                         duas pessoas.
                                                         """, EItemType.Miscellaneous, 2, ECurrencyType.Gold, 10.0),
            new ItemDataModel("Tocha", """
                                       A tocha queima por 1 hora, fornecendo luz 
                                       plena em um raio de 6 metros e penumbra por mais 6 
                                       metros. Se você realizar um ataque corpo-a-corpo com 
                                       uma tocha acesa e acertar, causa 1 de dano flamejante.
                                       """, EItemType.Miscellaneous, 1, ECurrencyType.Copper, 0.5),
            new ItemDataModel("Tinta (frasco de 30ml)", "", EItemType.Miscellaneous, 10, ECurrencyType.Gold, 0),
            new ItemDataModel("Vara (3 metros)", "", EItemType.Miscellaneous, 5, ECurrencyType.Copper, 3.5),
            new ItemDataModel("Vela", """
                                      Por uma hora, a vela emana luz plena em um 
                                      raio de 1,5 metro e penumbra por mais 1,5 metro.
                                      """, EItemType.Miscellaneous, 1, ECurrencyType.Copper, 0)
        );

        #endregion

        #region Potions

        modelBuilder.Entity<PotionDataModel>().HasData(
            new PotionDataModel(4, 2, 2, EPotionEffect.Healing, "Poção de Cura", """
                Um personagem que beber o líquido
                vermelho mágico deste frasco recupera 2d4+2 pontos de
                vida. Beber ou administrar uma poção exige uma ação.
                """, 50, ECurrencyType.Gold, 0.25),
            new PotionDataModel(4, 1, 0, EPotionEffect.Poison, "Veneno básico (frasco)", """
                Você pode usar o veneno contido
                nesse vidro para cobrir a lâmina de uma arma cortante ou
                perfurante ou até três peças de munição. Aplicar o veneno
                leva uma ação. Uma criatura atingida pela arma ou
                munição envenenada deve obter sucesso em um teste de
                resistência de Constituição CD 10 ou sofrerá 1d4 de dano
                de veneno. Uma vez aplicado, o veneno retém sua
                potência durante 1 minuto antes de secar.
                """, 100, ECurrencyType.Gold, 0),
            new PotionDataModel(4, 2, 2, EPotionEffect.Healing, "Fogo alquímico (frasco)", """
                Esse líquido pegajoso e adesivo
                inflama em contado com o ar. Usando uma ação, você
                pode arremessar esse frasco a até 6 metros de distância,
                quebrando-o com o impacto. Você deve realizar um ataque
                à distância contra uma criatura ou objeto, tratando o fogo
                alquímico como uma arma improvisada. Em um sucesso,
                o alvo sofre 1d4 de dano de fogo no início de cada um de
                seus turnos. Uma criatura pode terminar esse dano
                usando sua ação e fazendo um teste de Destreza CD 10
                para apagar as chamas.
                """, 50, ECurrencyType.Gold, 0.5)
        );

        #endregion

        #region Tools

        modelBuilder.Entity<ItemDataModel>().HasData(
            new ItemDataModel("Ferramentas de Carpinteiro", "", EItemType.Tool, 8, ECurrencyType.Gold, 3.0),
            new ItemDataModel("Ferramentas de Cartógrafo", "", EItemType.Tool, 15, ECurrencyType.Gold, 3.0),
            new ItemDataModel("Ferramentas de Costureiro", "", EItemType.Tool, 1, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Ferramentas de Coureiro", "", EItemType.Tool, 5, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Ferramentas de Entalhador", "", EItemType.Tool, 1, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Ferramentas de Ferreiro", "", EItemType.Tool, 20, ECurrencyType.Gold, 4.0),
            new ItemDataModel("Ferramentas de Funileiro", "", EItemType.Tool, 50, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Ferramentas de Joalheiro", "", EItemType.Tool, 25, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Ferramentas de Oleiro", "", EItemType.Tool, 10, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Ferramentas de Pedreiro", "", EItemType.Tool, 10, ECurrencyType.Gold, 4.0),
            new ItemDataModel("Ferramentas de Pintor", "", EItemType.Tool, 10, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Ferramentas de Sapateiro", "", EItemType.Tool, 5, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Ferramentas de Vidreiro", "", EItemType.Tool, 30, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Suprimentos de Alquimista", "", EItemType.Tool, 50, ECurrencyType.Gold, 4.0),
            new ItemDataModel("Suprimentos de Cervejeiro", "", EItemType.Tool, 20, ECurrencyType.Gold, 4.5),
            new ItemDataModel("Suprimentos de Caligrafia", "", EItemType.Tool, 10, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Utensílios de Cozinheiro", "", EItemType.Tool, 1, ECurrencyType.Gold, 4.0),


            new ItemDataModel("Ferramentas de navegação", """
                                                          Esse conjunto de instrumentos é usado para navegação no mar. 
                                                          Proficiência com as ferramentas de navegador permite 
                                                          traçar um curso de navio e seguir cartas de navegação. 
                                                          Além disso, essas ferramentas permitem que você 
                                                          adicione seu bônus de proficiência para qualquer teste de 
                                                          habilidade que fizer para não se perder no mar. 
                                                          """, EItemType.Tool, 25, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Ferramentas de ladrão", """
                                                          Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de 
                                                          chaves mestras, um pequeno espelho montado em uma 
                                                          alça de metal, um conjunto de tesouras de lâminas 
                                                          estreitas e um par de alicates. Proficiência com essas 
                                                          ferramentas permite adicionar o bônus de proficiência 
                                                          para quaisquer testes de habilidade que você fizer para 
                                                          desarmar armadilhas ou abrir fechaduras.
                                                          """, EItemType.Tool, 25, ECurrencyType.Gold, 0.5),

            new ItemDataModel("Alaúde", "", EItemType.Miscellaneous, 35, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Flauta", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Flauta de Pã", "", EItemType.Miscellaneous, 12, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Gaita de Foles", "", EItemType.Miscellaneous, 30, ECurrencyType.Gold, 3.0),
            new ItemDataModel("Lira", "", EItemType.Miscellaneous, 30, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Oboé", "", EItemType.Miscellaneous, 2, ECurrencyType.Gold, 0.5),
            new ItemDataModel("Tambor", "", EItemType.Miscellaneous, 6, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Trombeta", "", EItemType.Miscellaneous, 3, ECurrencyType.Gold, 1.0),
            new ItemDataModel("Violino", "", EItemType.Miscellaneous, 30, ECurrencyType.Gold, 3.0),
            new ItemDataModel("Xilofone", "", EItemType.Miscellaneous, 25, ECurrencyType.Gold, 5.0),
            new ItemDataModel("Kit de Disfarce", """
                                                 Essa bolsa de cosméticos, tintura de 
                                                 cabelo e pequenos adereços permite criar disfarces que 
                                                 mudam sua aparência física. Proficiência com este kit 
                                                 permite adicionar o bônus de proficiência para quaisquer 
                                                 testes de habilidade que você fizer para criar um disfarce 
                                                 visual.
                                                 """, EItemType.Miscellaneous, 25, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Kit de Falsificação", """
                                                     Essa pequena caixa contém uma 
                                                     variedade de papéis e pergaminhos, canetas e tintas, 
                                                     selos e lacres, folha de ouro e prata, e outros suprimentos 
                                                     necessários para criar falsificações convincentes de 
                                                     documentos físicos. Proficiência com esse kit permite 
                                                     adicionar o bônus de proficiência para quaisquer testes de 
                                                     habilidade que você fizer para criar uma falsificação de 
                                                     um documento físico.
                                                     """, EItemType.Miscellaneous, 15, ECurrencyType.Gold, 2.5),
            new ItemDataModel("Kit de Herbalismo", """
                                                   Esse kit contém uma variedade 
                                                   de instrumentos, como alicates, almofariz e pilão, e bolsas 
                                                   e frascos utilizados pelos herbalistas para criar remédios 
                                                   e poções. Proficiência com este kit permite adicionar o 
                                                   bônus de proficiência para quaisquer testes de habilidade 
                                                   que você fizer para identificar ou aplicar ervas. Além 
                                                   disso, a proficiência com esse kit é necessária para criar 
                                                   antídotos e poções de cura.
                                                   """, EItemType.Miscellaneous, 5, ECurrencyType.Gold, 1.5),
            new ItemDataModel("Baralho de Cartas", "", EItemType.Miscellaneous, 5, ECurrencyType.Silver, 0.0),
            new ItemDataModel("Conjunto de Dados", "", EItemType.Miscellaneous, 1, ECurrencyType.Silver, 0.0),
            new ItemDataModel("Jogo dos Três Dragões", "", EItemType.Miscellaneous, 5, ECurrencyType.Gold, 0.0),
            new ItemDataModel("Xadrez do Dragão", "", EItemType.Miscellaneous, 1, ECurrencyType.Gold, 0.25),
            new ItemDataModel("Kit de Venenos", """
                                                O kit de venenos inclui os frascos, 
                                                produtos químicos e outros equipamentos necessários 
                                                para a criação de venenos. Proficiência com esse kit 
                                                permite adicionar o bônus de proficiência para quaisquer 
                                                testes de habilidade que você fizer para criar ou utilizar 
                                                venenos.
                                                """, EItemType.Miscellaneous, 50, ECurrencyType.Gold, 1.0)
        );

        #endregion

        #endregion

        #region Classes

        modelBuilder.Entity<FeatureDataModel>().HasData(
            new FeatureDataModel("Visão no Escuro", """
                                                    Acostumado à vida subterrânea, 
                                                    você tem uma visão superior no escuro e na penumbra. 
                                                    Você enxerga na penumbra a até 18 metros como se fosse 
                                                    luz plena, e no escuro como se fosse na penumbra. Você 
                                                    não pode discernir cores no escuro, apenas tons de cinza.
                                                    """),
            new FeatureDataModel("Resiliência Anã", """
                                                     Você possui vantagem em testes de 
                                                    resistência contra venenos e resistência contra dano de 
                                                    veneno.
                                                    """),
            new FeatureDataModel("Especialização em Rochas", """
                                                    Sempre que você 
                                                    realizar um teste de Inteligência (História) relacionado à 
                                                    origem de um trabalho em pedra, você é considerado 
                                                    proficiente na perícia História e adiciona o dobro do seu 
                                                    bônus de proficiência ao teste, ao invés do seu bônus de 
                                                    proficiência normal.
                                                    """),
            new FeatureDataModel("Sentidos Aguçados", """
                                                    Você tem proficiência na perícia 
                                                    Percepção.
                                                    """),
            new FeatureDataModel("Ancestral Feérico", """
                                                      Você tem vantagem nos testes de 
                                                      resistência para resistir a ser enfeitiçado e magias não 
                                                      podem colocá-lo para dormir.
                                                      """),
            new FeatureDataModel("Transe", """
                                                      Elfos não precisam dormir. Ao invés disso, 
                                                      eles meditam profundamente, permanecendo 
                                                      semiconscientes, durante 4 horas por dia. (A palavra em 
                                                      idioma comum para tal meditação é "transe".) Enquanto 
                                                      medita, um elfo é capaz de sonhar de certo modo. Esses 
                                                      sonhos na verdade são exercícios mentais que se tornam 
                                                      reflexos através de anos de prática. Depois de descansar 
                                                      dessa forma, você ganha os mesmos benefícios que um 
                                                      humano depois de 8 horas de sono. 
                                                      """),
            new FeatureDataModel("Máscara da Natureza", """
                                                      Você pode tentar se esconder 
                                                      mesmo quando você está apenas levemente obscurecido  
                                                      por folhagem, chuva forte, neve caindo, névoa ou outro 
                                                      fenômeno natural.
                                                      """),
            new FeatureDataModel("Sensibilidade à Luz Solar", """
                                                        Você possui 
                                                        desvantagem nas jogadas de ataque e testes de Sabedoria 
                                                        (Percepção) relacionados a visão quando você, o alvo do 
                                                        seu ataque, ou qualquer coisa que você está tentando 
                                                        perceber, esteja sob luz solar direta.
                                                        """),
            new FeatureDataModel("Magia Drow", """
                                                        Você possui o truque globos de luz. 
                                                        Quando você alcança o 3° nível, você pode conjurar a 
                                                        magia fogo das fadas. Quando você alcança o 5° nível, 
                                                        você pode conjurar escuridão. Você precisa terminar um 
                                                        descanso longo para poder conjurar as magias desse traço 
                                                        novamente. Carisma é sua habilidade chave para 
                                                        conjurar essas magias.
                                                        """),
            new FeatureDataModel("Sortudo", """
                                                              Quando você obtiver um 1 natural em uma 
                                                              jogada de ataque, teste de habilidade ou teste de 
                                                              resistência, você pode jogar de novo o dado e deve utilizar 
                                                              o novo resultado.
                                                              """),
            new FeatureDataModel("Bravura", """
                                                              Você tem vantagem em testes de resistência 
                                                              contra ficar amedrontado. 
                                                              """),
            new FeatureDataModel("Agilidade Halfling", """
                                                              Você pode mover-se através do 
                                                              espaço de qualquer criatura que for de um tamanho maior 
                                                              que o seu.
                                                              """),
            new FeatureDataModel("Arma de Sopro", """
                                                       Você pode usar uma ação para 
                                                       exalar energia destrutiva. Seu ancestral dracônico 
                                                       determina o tamanho, formado e tipo de dano que você 
                                                       expele. 
                                                       Quando você usa sua arma de sopro, cada criatura na 
                                                       área exalada deve realizar um teste de resistência, o tipo 
                                                       do teste é determinado pelo seu ancestral dracônico. A CD 
                                                       do teste de resistência é 8 + seu modificador de 
                                                       Constituição + seu bônus de proficiência. Uma criatura 
                                                       sofre 2d6 de dano num fracasso e metade desse dano num 
                                                       sucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° 
                                                       nível e 5d6 no 16° nível. 
                                                       Depois de usar sua arma de sopro, você não poderá 
                                                       utilizá-la novamente até completar um descanso curto ou 
                                                       longo.
                                                       """),
            new FeatureDataModel("Resistência a Dano", """
                                                       Você possui resistência ao tipo 
                                                       de dano associado ao seu ancestral dracônico.
                                                       """),
            new FeatureDataModel("Esperteza Gnômica", """
                                                       Você possui vantagem em todos 
                                                       os testes de resistência de Inteligência, Sabedoria e 
                                                       Carisma contra magia.
                                                       """),
            new FeatureDataModel("Ilusionista Nato", """
                                                       Você conhece o truque ilusão 
                                                       menor. Inteligência é a sua habilidade usada para 
                                                       conjurá-la.
                                                       """),
            new FeatureDataModel("Falar com Bestas Pequenas", """
                                                       Através de sons e 
                                                       gestos, você pode comunicar ideias simples para Bestas 
                                                       pequenas ou menores. Gnomos da floresta amam os 
                                                       animais e normalmente possuem esquilos, doninhas, 
                                                       coelhos, toupeiras, pica-paus e outras criaturas como 
                                                       amados animais de estimação.
                                                       """),
            new FeatureDataModel("Conhecimento de Artífice", """
                                                       Toda vez que você fizer 
                                                       um teste de Inteligência (História) relacionado a itens 
                                                       mágicos, objetos alquímicos ou mecanismos tecnológicos, 
                                                       você pode adicionar o dobro do seu bônus de proficiência, 
                                                       ao invés de qualquer bônus de proficiência que você 
                                                       normalmente use.
                                                       """),
            new FeatureDataModel("Engenhoqueiro", """
                                                       Você possui proficiência com 
                                                       ferramentas de artesão (ferramentas de engenhoqueiro). 
                                                       Usando essas ferramentas, você pode gastar 1 hora e 10 
                                                       po em materiais para construir um mecanismo Miúdo (CA 
                                                       5, 1 pv). O mecanismo para de funcionar após 24 horas (a 
                                                       não ser que você gaste 1 hora reparando-o para manter o 
                                                       mecanismo funcionando), ou quando você usa sua ação 
                                                       para desmantelá-lo; nesse momento, você pode recuperar 
                                                       o material usado para criá-lo. Você pode ter até três
                                                        desses mecanismos ativos ao mesmo tempo.
                                                       """),
            new FeatureDataModel("Resistência Implacável", """
                                                       Quando você é reduzido a 
                                                       0 pontos de vida mas não é completamente morto, você 
                                                       pode voltar para 1 ponto de vida. Você não pode usar essa 
                                                       característica novamente até completar um descanso 
                                                       longo.
                                                       """),
            new FeatureDataModel("Ataques Selvagens", """
                                                       Quando você atinge um ataque 
                                                       crítico com uma arma corpo-a-corpo, você pode rolar um 
                                                       dos dados de dano da arma mais uma vez e adicioná-lo ao 
                                                       dano extra causado pelo acerto crítico.
                                                       """),
            new FeatureDataModel("Resistência Infernal", """
                                                       Você possui resistência a dano 
                                                       de fogo.
                                                       """),
            new FeatureDataModel("Legado Infernal", """
                                                       Você conhece o truque 
                                                       taumaturgia. Quando você atingir o 3° nível, você poderá 
                                                       conjurar a magia repreensão infernal como uma magia de 
                                                       2° nível. Quando você atingir o 5° nível, você também 
                                                       poderá conjurar a magia escuridão. Você precisa terminar 
                                                       um descanso longo para poder usar as magias desse traço 
                                                       novamente. Sua habilidade de conjuração para essas 
                                                       magias é Carisma.
                                                       """)
            );

        #endregion

        #region Features



        #endregion
    }
}
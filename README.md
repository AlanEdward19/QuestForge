# QuestForge

**QuestForge** é uma plataforma abrangente para jogar RPG de mesa online, utilizando as regras de Dungeons & Dragons 5ª Edição (D&D 5e). A plataforma é composta por múltiplos microserviços, cada um responsável por diferentes aspectos da experiência de jogo. A principal função do QuestForge é auxiliar mestres de RPG, proporcionando uma interface rica e ferramentas poderosas para a criação e gestão de campanhas.

## Microserviços

### CharacterService

- **Criação de Personagens**: Permite a criação de personagens com todas as classes, raças e itens conforme as regras do livro do jogador de D&D 5e.
- **Gestão de Personagens**: Atualização e gerenciamento contínuo dos personagens, incluindo níveis, experiência, habilidades e itens.
- **Exportação de Ficha**: Exportação de fichas de personagens em formatos padrão para fácil utilização durante as sessões de jogo.

### NPCService (Planejado)

- **Interação com NPCs**: Utiliza a tecnologia da OpenAI para permitir conversas interativas e dinâmicas com NPCs criados pelos mestres, proporcionando uma experiência de jogo mais imersiva.
- **Interação por Texto ou Voz**: NPCs podem interagir com jogadores através de texto ou voz, utilizando tecnologia TTS (Texto para Fala), auxiliando o mestre a não ter que interpretar todos os NPCs.

### WorldBuilderService (Planejado)

- **Criação de Mundos**: Ferramentas para a criação de mundos detalhados onde as campanhas podem acontecer, com a capacidade de definir geografias, climas, ecossistemas e mais.
- **Gestão de Localizações**: Criação e gerenciamento de localizações dentro dos mundos criados, incluindo cidades, vilarejos, masmorras e outros pontos de interesse onde os personagens podem viver e interagir.
- **Mapas Dinâmicos**: Criação dinâmica de mapas mundi e das localizações específicas dentro da campanha, facilitando a visualização e a navegação pelos jogadores.


## Web Application

- **Interface Interativa**: Uma interface web interativa para criar e gerenciar personagens, NPCs, mundos e localizações.
- **Participação em Sessões de Jogo**: Ferramentas para facilitar a participação em sessões de jogo, incluindo gerenciamento de iniciativas, rastreamento de estados dos personagens e comunicação com outros jogadores.
- **Interação com NPCs**: Permite que os jogadores interajam com NPCs criados, seja por texto ou por voz, dentro das localizações especificadas pelo mestre.
- **Imagens Personalizadas**: Cada personagem criado terá uma imagem gerada dinamicamente, melhorando a imersão visual do jogo.

## Tecnologias Utilizadas

- **.NET 8**
- **Entity Framework Core**
- **CQRS (Command Query Responsibility Segregation)**
- **Domain-Driven Design (DDD)**
- **Onion Architecture**

Com esses componentes, o **QuestForge** visa fornecer uma plataforma completa para mestres de D&D 5e, facilitando a criação de histórias envolventes e a gestão de aventuras épicas, enquanto minimiza a carga de trabalho do mestre através da automação e integração de tecnologias avançadas.

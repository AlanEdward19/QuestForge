# QuestForge

## Visão Geral

O **QuestForge** é uma plataforma abrangente para jogar RPG de mesa online, utilizando as regras de Dungeons & Dragons 5ª Edição (D&D 5e). A plataforma é composta por múltiplos microserviços, cada um responsável por diferentes aspectos da experiência de jogo. Até agora, temos o `CharacterCreationService`, responsável pela criação, gestão e exportação de personagens.

## Microserviços

### CharacterService

- **Criação de Personagens:** Permite a criação de personagens com todas as classes, raças e itens conforme as regras do livro do jogador de D&D 5e.
- **Gestão de Personagens:** Atualização e gerenciamento contínuo dos personagens, incluindo níveis, experiência, habilidades e itens.
- **Exportação de Ficha:** Exportação de fichas de personagens em formatos padrão para fácil utilização durante as sessões de jogo.
- **Armazenamento Persistente:** Utiliza Entity Framework Core para armazenar e gerenciar os dados dos personagens em um banco de dados relacional.

### Estrutura do Projeto

A plataforma **QuestForge** é estruturada utilizando Domain-Driven Design (DDD) e a arquitetura Onion para garantir uma separação clara das preocupações e alta manutenibilidade.

#### Camadas do CharacterCreationService

- **Application:** Contém os comandos e consultas (CQRS) que manipulam as ações de criação, atualização e consulta de personagens.
- **Core:** Define as entidades de domínio, agregados, enums, serviços e interfaces dos repositórios.
- **Infrastructure:** Implementa os repositórios, configurações do Entity Framework Core e o contexto do banco de dados.

## Tecnologias Utilizadas

- **.NET 8**
- **Entity Framework Core**
- **CQRS (Command Query Responsibility Segregation)**
- **Domain-Driven Design (DDD)**
- **Onion Architecture**

## Futuro da Plataforma

A plataforma **QuestForge** está em contínuo desenvolvimento e outros serviços estão planejados, incluindo:

- **GameSessionService:** Gerenciamento de sessões de jogo e controle de turnos.
- **InventoryService:** Gestão detalhada de inventário e itens mágicos.
- **CombatService:** Resolução de combates e aplicação de regras de combate.
- **Web Application:** Interface web interativa para criar e gerenciar personagens, participar de sessões de jogo e acessar fichas de personagens.

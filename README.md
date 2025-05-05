# microprojeto-aspnet-ListOfContacts

<img src="wwwroot/img/videoListOfContacts.gif" width=800px>

## **Descrição**
O **microprojeto-aspnet-ListOfContacts** é uma aplicação desenvolvida com Blazor e .NET 9 para gerenciar contatos de forma eficiente. A aplicação permite criar, editar, visualizar e excluir contatos, oferecendo uma interface moderna e responsiva.

## **Funcionalidades**
- **Gerenciamento de Contatos**:
  - Adicionar novos contatos com informações detalhadas.
  - Editar e excluir contatos existentes.
  - Validação de dados no formulário.
- **Interface Responsiva**:
  - Construída com Bootstrap para garantir compatibilidade com dispositivos móveis e desktops.
- **Upload de Arquivos**:
  - Suporte para upload de imagens de perfil dos contatos.
- **Acessibilidade**:
  - Implementação de boas práticas para acessibilidade, como o uso de `role="button"`.

## **Tecnologias Utilizadas**
- **Blazor**: Framework para desenvolvimento de interfaces web interativas.
- **.NET 9**: Plataforma para desenvolvimento de aplicações modernas e de alto desempenho.
- **C# 13.0**: Linguagem de programação utilizada no backend e na lógica do Blazor.
- **Bootstrap**: Framework CSS para design responsivo.

## **Estrutura do Projeto**
### **Páginas**
- **`Pages/Contacts/Create.razor`**:
  - Página para criação de novos contatos.
  - Inclui formulários com validação e suporte para upload de arquivos.
- **`Pages/Contacts/Edit.razor`**:
  - Página para edição de contatos existentes.
- **`Pages/Contacts/List.razor`**:
  - Página para exibição da lista de contatos cadastrados.

### **Modelos**
- **`Contact`**:
  - Modelo de dados utilizado para representar os contatos.
  - Propriedades:
    - `Id`: Identificador único do contato.
    - `Name`: Nome do contato.
    - `Email`: E-mail do contato.
    - `Phone`: Telefone do contato.
    - `Address`: Endereço do contato.
    - `City`: Cidade do contato.
    - `ImageFileName`: Nome do arquivo de imagem do contato.
    - `CreatedAt`: Data de criação do contato.

## **Como Executar o Projeto**
1. Certifique-se de ter o **.NET 9 SDK** instalado.
2. Clone o repositório do projeto: `git clone <URL_DO_REPOSITORIO>`
3. Navegue até o diretório do projeto: `cd <DIRETORIO_DO_PROJETO>`
4. Restaure as dependências: `dotnet restore`
5. Execute o projeto: `dotnet run`
6. Acesse a aplicação no navegador em `http://localhost:5000`.

## **Validação**
- A validação é implementada usando `DataAnnotations` no modelo `Contact` para garantir que os dados inseridos atendam aos requisitos, como o limite de caracteres para `Name` e `Email`.
- Mensagens de erro são exibidas ao lado dos campos do formulário usando componentes de validação do Blazor.

## **Créditos**
Este projeto foi desenvolvido como parte de um microprojeto para aprendizado e prática de Blazor e .NET 9. Agradecimentos à comunidade de desenvolvedores por compartilhar recursos e tutoriais que ajudaram na construção desta aplicação.
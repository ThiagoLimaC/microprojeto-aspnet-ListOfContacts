# microprojeto-aspnet-ListOfContacts

<img src="wwwroot/img/videoListOfContacts.gif" width=800px>

## **Descri��o**
O **microprojeto-aspnet-ListOfContacts** � uma aplica��o desenvolvida com Blazor e .NET 9 para gerenciar contatos de forma eficiente. A aplica��o permite criar, editar, visualizar e excluir contatos, oferecendo uma interface moderna e responsiva.

## **Funcionalidades**
- **Gerenciamento de Contatos**:
  - Adicionar novos contatos com informa��es detalhadas.
  - Editar e excluir contatos existentes.
  - Valida��o de dados no formul�rio.
- **Interface Responsiva**:
  - Constru�da com Bootstrap para garantir compatibilidade com dispositivos m�veis e desktops.
- **Upload de Arquivos**:
  - Suporte para upload de imagens de perfil dos contatos.
- **Acessibilidade**:
  - Implementa��o de boas pr�ticas para acessibilidade, como o uso de `role="button"`.

## **Tecnologias Utilizadas**
- **Blazor**: Framework para desenvolvimento de interfaces web interativas.
- **.NET 9**: Plataforma para desenvolvimento de aplica��es modernas e de alto desempenho.
- **C# 13.0**: Linguagem de programa��o utilizada no backend e na l�gica do Blazor.
- **Bootstrap**: Framework CSS para design responsivo.

## **Estrutura do Projeto**
### **P�ginas**
- **`Pages/Contacts/Create.razor`**:
  - P�gina para cria��o de novos contatos.
  - Inclui formul�rios com valida��o e suporte para upload de arquivos.
- **`Pages/Contacts/Edit.razor`**:
  - P�gina para edi��o de contatos existentes.
- **`Pages/Contacts/List.razor`**:
  - P�gina para exibi��o da lista de contatos cadastrados.

### **Modelos**
- **`Contact`**:
  - Modelo de dados utilizado para representar os contatos.
  - Propriedades:
    - `Id`: Identificador �nico do contato.
    - `Name`: Nome do contato.
    - `Email`: E-mail do contato.
    - `Phone`: Telefone do contato.
    - `Address`: Endere�o do contato.
    - `City`: Cidade do contato.
    - `ImageFileName`: Nome do arquivo de imagem do contato.
    - `CreatedAt`: Data de cria��o do contato.

## **Como Executar o Projeto**
1. Certifique-se de ter o **.NET 9 SDK** instalado.
2. Clone o reposit�rio do projeto: `git clone <URL_DO_REPOSITORIO>`
3. Navegue at� o diret�rio do projeto: `cd <DIRETORIO_DO_PROJETO>`
4. Restaure as depend�ncias: `dotnet restore`
5. Execute o projeto: `dotnet run`
6. Acesse a aplica��o no navegador em `http://localhost:5000`.

## **Valida��o**
- A valida��o � implementada usando `DataAnnotations` no modelo `Contact` para garantir que os dados inseridos atendam aos requisitos, como o limite de caracteres para `Name` e `Email`.
- Mensagens de erro s�o exibidas ao lado dos campos do formul�rio usando componentes de valida��o do Blazor.

## **Cr�ditos**
Este projeto foi desenvolvido como parte de um microprojeto para aprendizado e pr�tica de Blazor e .NET 9. Agradecimentos � comunidade de desenvolvedores por compartilhar recursos e tutoriais que ajudaram na constru��o desta aplica��o.
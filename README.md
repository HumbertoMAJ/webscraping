# Web Scraping integrado a um banco de dados
  ![Alimentos](https://github.com/HumbertoMAJ/webscraping/assets/79175703/887055f4-8471-410e-9d4d-637131b9a4da)

## Descrição
Este projeto de Web Scraping usando o framework .NET visa extrair informações do site "tbca.net.br" e apresentá-las de forma organizada em uma aplicação web. A aplicação será desenvolvida usando o padrão MVC (Model-View-Controller) entre outras tecnologias. 

## Construido com
- **HTML / CSS/ BOOTSTRAP** - Essas tecnologias trabalham juntas para criar páginas da web visualmente atraentes, bem estruturadas e funcionais.
- **DataTable(Biblionteca javascript)** - Para a manipulação de tabelas HTML. Ele permite que você adicione recursos avançados às tabelas, como ordenação, filtragem, paginação e muito mais, tudo isso de uma forma altamente personalizável e fácil de implementar.
- **Html Agility Pack** - Para manipular e extrair dados de documentos HTML de uma forma flexível e eficiente.
- **Linguagem C# utilizando Framework .NET 6** - O framework .NET 6 oferece uma plataforma robusta e moderna para o desenvolvimento de uma ampla variedade de aplicativos.
- **Entity Framework** -  Ele é uma estrutura de mapeamento objeto-relacional (ORM) para o desenvolvimento de aplicações .NET. Ele simplifica o acesso e manipulação de dados em bancos de dados relacionais usando objetos.
- **Banco de dados Sql Server** - O SQL Server é um sistema de gerenciamento de banco de dados relacional (SGBDR).
## Funcionalidades
- **Raspagem de dados** - Extração de informações de alimentos: Código, Nome, Nome Cientifico, Grupo, e de todos os componentes e informações sobre os componentes que são: unidades, valor por 100g, desvio padrão, valor mínimo, valor máximo, numero de dados utilizados, referências, tipo de dados.
- **Armazenamento dos dados** - Os dados extraídos são armazenados em um banco de dados e retorna para que o usuário possa vizualizar.
- **Interface interativa** - O Usuário pode ver os alimentos e sua composição além de poder pesquisar o alimento e poder mostrar de 10, 25, 50, 100 alimentos por página.
## Instruções de Instalação e Uso
- **Sistema Operacional:** - Windows, Linux ou macOS
- **Plataforma .NET:** - Certifique-se de ter o SDK do .NET 6 instalado em sua máquina.
- **SQL Server:** - Tenha o SQL Server instalado em sua máquina ou em um servidor acessível.
- **Clonar o repositório:** - Clone este repositório para sua máquina local usando o seguinte comando:
   
```
git clone https://github.com/HumbertoMAJ/webscraping.git
```
- **Configuração do Banco de Dados** 
  - Crie um banco de dados no SQL Server para armazenar os dados do scraping.
  - Abra o arquivo appsettings.json e atualize a string de conexão (ConnectionStrings) com os detalhes do seu banco de dados.
- **Acesso à Aplicação** - pós a execução bem-sucedida, abra um navegador da web e acesse http://localhost:5000/alimentos

## Recursos visuais
### Composição

  ![Composição](https://github.com/HumbertoMAJ/webscraping/assets/79175703/3225b5ec-744b-4d2c-aa01-d5aefd52c038)
  
### Pesquisa

  ![Pesquisa](https://github.com/HumbertoMAJ/webscraping/assets/79175703/6f6fc5b9-57a9-470d-b3f2-595b6b2b6894)
  
### Banco de dados

  ![sqlserver](https://github.com/HumbertoMAJ/webscraping/assets/79175703/cb0c462d-4926-4ff2-8707-bac0e883482b)



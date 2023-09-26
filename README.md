Vamos mostrar a implementação da Clean Architecture em um projeto ASP.NET Core Web API que vai gerenciar informações sobre usuários definidos pela entidade User que vai conter as propriedades Email e Name. (Estamos simplificando o modelo de domínio)

Para aplicar a Arquitetura Limpa, podemos dividir a aplicação em quatro camadas:

Camada de domínio → o projeto que contém a camada de domínio, incluindo entidades, objetos de valor e serviços de domínio;
Camada de Aplicação → o projeto que contém a camada de aplicação e implementa os serviços de aplicação, DTOs (objetos de transferência de dados) e mapeadores. Ele deve fazer referência ao projeto de domínio;
Camada de infraestrutura → O projeto contém a camada de infraestrutura, incluindo a implementação de acesso a dados, registro, e-mail e outros mecanismos de comunicação. Ele deve fazer referência ao projeto do aplicativo:
Camada de apresentação → O projeto principal contém a camada de apresentação e implementa a API da Web ASP.NET Core. Deve fazer referência aos projetos de Aplicativo e Infraestrutura;

Podemos identificar neste projeto os seguintes componentes:

Uma solução em branco - Blank Solution - CleanArchitecture;

4 Solution Folders :  Core , Infrastructure, Presentation e Test;

  Core :  Contém dois projetos do tipo Class Library : CleanArchitecdture.Domain e CleanArchitecdture.Application
  Infrastructure : Contém um projeto do tipo Class Library : CleanArchitecdture.Persistence
  Presentation : Contém um projeto do tipo Asp.Net Core Web Api : CleanArchitecdture.WebAPI
  Test : Contém um projeto do tipo xUnit : CleanArchitecdture.UnitTest

O objetivo é mostrar de forma simplificada a implementação do padrão CQRS usando a Clean Architecture  


## O que é essa respositório?

O objetivo desse repositório é mostrar que é possível dar build em um projeto com uma package externa ao repositório oficial do NuGet, o grande segredo não está dentro do projeto e sim como essa referência é mapeada dentro do NuGet.

No VStudio por exemplo é possível fazer isso via GUI em Manage NuGet Packages adicionando um novo Package source.

Nesse exemplo mostro como adicionar o referência do FastReport .NET versão paga.

## 1º Caminho

1 - Baixar o nuget cli.
https://www.nuget.org/downloads

2 - Adicionar em variáveis de ambiente.

3 - Fonte de pesquisa do dotnet com o nuget.
dotnet nuget list source

4 - Lista os pacotes que estão dentro da pasta.
nuget list -source 'C:\Program Files (x86)\FastReports\FastReport.Net\Nugets'
OU
dotnet nuget -source 'FastReport .NET'

5 - Instala o pacote, nesse momento é criado uma pasta no projeto com a lib.
nuget install FastReport.Core -source 'C:\Program Files (x86)\FastReports\FastReport.Net\Nugets'

## 2º Caminho

1 - Adiciona ao dotnet o source do FastReport.
dotnet nuget add source 'C:\Program Files (x86)\FastReports\FastReport.Net\Nugets' -n FastReport

## Ambos os caminhos

1 - Adicionar o pacote já mapeado no projeto.
dotnet add package FastReport.Core

## Comandos extras

4 - Remove o source do dotnet nuget.
dotnet nuget remove source FastReport.NET
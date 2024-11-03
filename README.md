# Configurando a sua máquina

Processo para configurar e executar cada projeto após fazer o clone do repositório para a sua máquina:

### Certifique-se de que o .NET SDK esteja instalado:

Verifique se o .NET SDK está instalado executando no terminal.

```
dotnet --version 
```

Caso não esteja, baixe-o e instale-o a partir do site oficial .NET.

### Entre na pasta do projeto:

Use o terminal ou o prompt de comando para navegar até a pasta do projeto que você clonou:

```
cd NOME_DO_PROJETO
```
### Restaure as dependências:

Execute o comando dotnet restore. Esse comando baixa todas as dependências e recria a estrutura de pastas necessária para compilar o projeto, incluindo as pastas bin/ e obj/:

```
dotnet build
```
### Compile e execute o projeto:

Para executar o projeto, você pode usar:

```
dotnet run
```

Esse comando compila e executa o projeto, recriando todos os arquivos de build temporários que foram ignorados no Git.

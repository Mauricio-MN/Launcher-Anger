# Launcher-Anger
Um projeto de launcher simples que fiz a muito tempo atrás.

- Faz update automático de arquivos usando crc32
- Faz update automático do launcher

## AutoUpdateLauncher
Coloque em um diretório remoto (https) um arquivo launcher_version.txt, sempre que atualizar o launcher faça alterações no arquivo (ex: 0.01 -> 0.02).
Os links de procura podem ser alterados no código fonte.
Esse deverá ser executado no lugar do launcher, é responsável por atualiza-lo, o launcher pode atualizar esse executável logo após.

## GeradorDeUpdate
Após dar Build no projeto crie um pasta "updates" no diretório do executável, nela devem ficar os arquivos novos a se atualizar.
Abra o executável e gere o update, um arquivo chamado "updates.txt" sera criado, pegue os arquivos da pasta updates e "updates.txt" e carregue para um diretório remoto (https).
Os links de procura podem ser alterados no código fonte.

## Launcher
Os links de procura podem ser alterados no código fonte.
Seram verificados os arquivos por meio do link para o arquivo "updates.txt".

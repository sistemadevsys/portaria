# GSportaria DevSys

## Table of Contents

- [About](#about)
- [Getting Started](#getting_started)
- [Usage](#usage)
- [Contributing](#CONTRIBUTING)

## About <a name = "about"></a>

Projeto Gs Portaria

## Getting Started <a name = "getting_started"></a>


Para iniciar o projeto é preciso usar o sistema operacional Windows 10 ou 11.

### Prerequisites

Clonar o repositório no Github:

```
git clone https://github.com/sistemadevsys/portaria.git
```

Veja em [Homehost](https://homehost.com.br) para mais detalhes do banco de dados MySQL na nuvem.

### Installing

Instalar o Visual Studio local, e após fazer a instalação do MySQL local com o Pluguin do Visual Studio.

Executar os dumps dos bancos de dados MySQL no servidor da nuvem e no servidor local.
Os dumps e outros arquivos é encontrado em arquivos no login do site [DevSys](https://devsys.com.br)
 ----- 
Criar novo usuário para o MySQL:
```
select user, host from mysql.user; # Verificar usuários
CREATE USER 'devsys'@'localhost' IDENTIFIED WITH mysql_native_password BY 'your_p@ssword';
GRANT ALL PRIVILEGES ON gstec.* TO'devsys'@'localhost';
FLUSH PRIVILEGES;
```
Excluir usuário e após dar privilégios necessário aos bancos de dados MySQL:
```
select user, host from mysql.user;
drop user devsys@localhost;
CREATE USER 'devsys'@'localhost' IDENTIFIED BY 'your_p@ssword';
GRANT ALL ON *.* TO 'devsy'@'localhost';
ALTER USER 'devsys'@'localhost' IDENTIFIED WITH mysql_native_password BY 'your_p@ssword';
FLUSH PRIVILEGES;
```

## Usage <a name = "usage"></a>

Ao executar o sistema, ele irá pedir os dados para gravar no arquivo .ini. Entre com os dados de acesso dos servidores.

## Contributing <a name = "CONTRIBUTING"></a>
- [Cesar](https://CesarAugusto88.github.io)
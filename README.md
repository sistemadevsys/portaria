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

Para desenvolvimento, instalar o Visual Studio local, e após fazer a instalação do MySQL local com o Pluguin do Visual Studio. Para executar o sistema instalar o MySQL installer community 8.0.18.0

Executar os dumps dos bancos de dados MySQL no servidor da nuvem, se não houver o banco já criado, e no servidor local.
Os dumps e outros arquivos é encontrado em arquivos no login do site [DevSys](https://devsys.com.br)
 ----- 
Criar novo usuário devsys para o MySQL e dar privilégios a ele e ao usuário root:
```
select user, host from mysql.user; # Verificar usuários
CREATE USER 'devsys'@'localhost' IDENTIFIED WITH mysql_native_password BY 'your_p@ssword';
GRANT ALL ON `gstec`.* TO 'devsys'@'localhost';
GRANT ALL ON `gstec`.* TO 'root'@'%';
FLUSH PRIVILEGES;
```
Excluir usuário e criar novamente dando privilégios necessário aos bancos de dados MySQL:
```
select user, host from mysql.user;
drop user devsys@localhost;
CREATE USER 'devsys'@'localhost' IDENTIFIED BY 'your_p@ssword';
GRANT ALL PRIVILEGES ON gstec.* TO 'devsys'@'localhost';
GRANT ALL PRIVILEGES ON gstec.* TO 'devsys'@'%';
GRANT ALL PRIVILEGES ON gstec.* TO 'root'@'localhost';
GRANT ALL PRIVILEGES ON gstec.* TO 'root'@'%';
ALTER USER 'devsys'@'localhost' IDENTIFIED WITH mysql_native_password BY 'your_p@ssword';
FLUSH PRIVILEGES;
```

## Usage <a name = "usage"></a>

Ao executar o sistema, ele irá pedir os dados para gravar no arquivo .ini. Entre com os dados de acesso dos servidores.

## Contributing <a name = "CONTRIBUTING"></a>
- [Cesar](https://CesarAugusto88.github.io)
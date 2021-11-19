CREATE TABLE IF NOT EXISTS Responsable (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name VARCHAR(100) NOT NULL,
    Lastname VARCHAR(100) NOT NULL,
    Birthday date NOT NULL
);

CREATE TABLE IF NOT EXISTS Tasca (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name VARCHAR(100) NOT NULL,
    Descripcio VARCHAR(500) NOT NULL,
    Responsable_tasca VARCHAR(100) NOT NULL,
    Colors ENUM(red,yellow, green)NOT NULL,
    Data_final date NOT NULL,
    data_inici date NOT NULL

   
       
);


-- 1. Crear la base de datos (si no existe) y usarla
CREATE DATABASE IF NOT EXISTS sorveteria_projeto;
USE sorveteria_projeto;

-- 2. Crear Tabla Categorias (Tipos de helado en Portugués)
CREATE TABLE IF NOT EXISTS Categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre_categoria VARCHAR(50) NOT NULL
);

-- Insertar las categorías
INSERT INTO Categorias (nombre_categoria) VALUES 
('Cremes Clássicos'), 
('Frutas Brasileiras & Sorbets'), 
('Gourmet & Chocolates de Marca'), 
('Veganos / Sem Lactose'), 
('Picolés & Sobremesas');

-- 3. Crear Tabla Productos (Sabores)
CREATE TABLE IF NOT EXISTS Productos (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    nombre_producto VARCHAR(100) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL, -- Precio en Reales (R$)
    stock INT NOT NULL, 
    id_categoria INT,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria)
);

-- 4. Insertar 100 Sabores (Registros)
INSERT INTO Productos (nombre_producto, precio, stock, id_categoria) VALUES
('Baunilha de Madagascar', 14.38, 74, 1), ('Chocolate Belga', 13.57, 64, 1), ('Morango ao Leite', 13.88, 27, 1), ('Doce de Leite Mineiro', 12.61, 73, 1), ('Flocos', 17.46, 21, 1),
('Coco Branco', 15.33, 90, 1), ('Creme do Céu', 14.76, 63, 1), ('Napolitano', 12.61, 72, 1), ('Banana Caramelada', 14.52, 95, 1), ('Pistache', 19.42, 81, 1),
('Chocolate Branco', 15.34, 84, 1), ('Avelã', 15.71, 49, 1), ('Cookies & Cream', 15.91, 37, 1), ('Menta com Chocolate', 14.18, 14, 1), ('Cereja ao Marrasquino', 14.65, 15, 1),
('Passas ao Rum', 18.04, 18, 1), ('Iogurte com Amora', 12.84, 85, 1), ('Nata com Goiabada', 17.4, 95, 1), ('Milho Verde', 18.87, 99, 1), ('Pavê Italiano', 19.45, 6, 1),
('Limão Siciliano', 16.33, 17, 2), ('Maracujá', 15.73, 79, 2), ('Manga', 15.69, 95, 2), ('Açaí Puro', 10.92, 87, 2), ('Cupuaçu', 13.04, 76, 2),
('Graviola', 13.54, 80, 2), ('Cajá', 11.38, 56, 2), ('Acerola', 15.62, 14, 2), ('Uva', 15.5, 68, 2), ('Abacaxi com Hortelã', 15.35, 96, 2),
('Melancia', 16.59, 43, 2), ('Pitaya', 12.64, 72, 2), ('Goiaba', 14.3, 36, 2), ('Tangerina', 14.79, 83, 2), ('Frutas Vermelhas', 16.93, 10, 2),
('Limão com Gengibre', 15.51, 81, 2), ('Laranja', 10.07, 98, 2), ('Jabuticaba', 14.73, 77, 2), ('Seriguela', 14.82, 69, 2), ('Coco Verde', 14.06, 43, 2),
('Nutella Puro', 25.48, 41, 3), ('Kinder Ovo', 18.75, 46, 3), ('Ferrero Rocher', 18.33, 24, 3), ('KitKat', 26.58, 58, 3), ('Ovomaltine', 25.86, 99, 3),
('Chocolate Lindt', 18.47, 54, 3), ('Rafaello', 23.04, 99, 3), ('Sonho de Valsa', 21.77, 12, 3), ('Diamante Negro', 17.8, 80, 3), ('Laka', 23.4, 52, 3),
('Brigadeiro de Panela', 20.86, 38, 3), ('Leite Ninho com Nutella', 23.27, 79, 3), ('Romeu e Julieta', 26.63, 27, 3), ('Torta de Limão', 23.09, 26, 3), ('Cheesecake de Frutas Vermelhas', 25.66, 92, 3),
('Brownie', 21.58, 26, 3), ('Petit Gâteau', 25.36, 48, 3), ('Alpino', 20.21, 9, 3), ('Galak', 20.34, 43, 3), ('Sensação', 24.16, 83, 3),
('Chocolate 70% Cacau', 24.65, 94, 4), ('Mousse de Abacate e Lima', 23.03, 99, 4), ('Paçoca Vegana', 23.6, 89, 4), ('Banana com Canela', 15.26, 39, 4), ('Coco Queimado Vegano', 23.02, 74, 4),
('Frutas do Bosque', 22.72, 46, 4), ('Manga e Gengibre', 19.99, 59, 4), ('Sorbet de Cacau', 22.8, 53, 4), ('Tapioca com Coco', 15.82, 40, 4), ('Goiabada Cascão', 18.12, 34, 4),
('Pistache Vegano', 21.33, 93, 4), ('Avelã Vegana', 17.41, 36, 4), ('Caramelo Salgado Vegano', 15.77, 29, 4), ('Café Cold Brew', 21.5, 99, 4), ('Matcha Latte', 18.87, 31, 4),
('Leite de Amêndoas com Baunilha', 19.39, 89, 4), ('Chai Vegano', 17.88, 82, 4), ('Abacaxi ao Vinho', 22.3, 21, 4), ('Pêra ao Vinho', 18.78, 87, 4), ('Mousse de Maracujá', 22.42, 86, 4),
('Picolé de Brigadeiro', 23.14, 9, 5), ('Picolé de Frutas', 34.9, 77, 5), ('Picolé Recheado', 38.91, 69, 5), ('Moreninha', 26.51, 71, 5), ('Skimo', 36.84, 21, 5),
('Sanduíche de Sorvete', 21.28, 34, 5), ('Cassata', 39.28, 11, 5), ('Torta de Sorvete', 32.6, 50, 5), ('Sundae de Caramelo', 32.35, 47, 5), ('Sundae de Chocolate', 29.37, 51, 5),
('Milkshake de Ovomaltine', 37.84, 19, 5), ('Milkshake de Morango', 34.32, 41, 5), ('Banana Split', 21.48, 15, 5), ('Colegial', 36.89, 6, 5), ('Vaca Preta', 39.93, 62, 5),
('Copo da Felicidade', 25.49, 46, 5), ('Açaí na Tigela', 21.81, 66, 5), ('Cone Trufado', 24.11, 49, 5), ('Paleta Mexicana de Morango', 26.45, 92, 5), ('Paleta Mexicana de Leite Ninho', 32.91, 74, 5);
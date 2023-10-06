# Skeleton-3-Capas
Explicacion de los EndPoint Consultas Grpo "B"

- Listar todas las mascotas agrupadas por especie.
- Listar todos los movimientos de medicamentos y el valor total de cada movimiento.
- Listar las mascotas que fueron atendidas por un determinado veterinario.
- Listar los proveedores que me venden un determinado medicamento.
- Listar las mascotas y sus propietarios cuya raza sea Golden Retriver
- Listar la cantidad de mascotas que pertenecen a una raza a una raza. Nota: Se debe mostrar una lista de las razas y la cantidad de mascotas que pertenecen a la raza.

## Migraciones
dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations/

dotnet ef database update --project ./Infrastructure/ --startup-project ./API/  

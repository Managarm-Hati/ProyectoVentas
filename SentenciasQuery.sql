create proc DashboardDatos
@CantProductos float out
as
set @CantProductos=(select count(CODIGO) as CantProductos from tableVentas )
go

---Productos preferidos por clientes
select top 5  nombreArticulo ,COUNT(Codigo) as CantSalidas
from tableVentas
group by  codigo, nombreArticulo
order by COUNT (2) desc

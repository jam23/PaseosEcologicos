

--Select 
--	sc.ReservacionId,
--	Coalesce(c.Nombre, '') + ' ' + coalesce(c.Apellido, '') as Respresentate,
--	SUM(s.Precio) as PrecioTotalPorReservacion
--From  Clientes c inner join Reservaciones r 
--on r.ClienteId = c.Id inner join Servicios_Consumidos sc 
--on r.Id = sc.ReservacionId inner join Servicios s 
--on sc.ServicioId = s.Id
--GROUP BY sc.ReservacionId, COALESCE (c.Nombre, '') + ' ' + COALESCE (c.Apellido, '')


create view vReporteDeCosumo
as
Select 
	r.Id as ReservacionId,
	r.PaseoId,
	p.Titulo as [TituloDePaseo],
	c.Id as ClienteId,
	Coalesce(c.Nombre, '') + ' ' + coalesce(c.Apellido, '') as Cliente,
	c.Celular,
	c.Correo,
	ca.Id as [RepresentateId],
	Coalesce(ca.Nombre, '') + ' ' + coalesce(ca.Apellido, '') as Representante,
	ca.Celular as [TelRepresentante],
	ca.Correo as [CorreoRepresentante],
	sc.ServicioId,
	ts.Titulo as TipoDeServicio,
	s.Titulo as ServicioConsumido,
	s.Precio as PrecioDeServicioConsumido
from  Clientes c left join Clientes ca
on c.AfiliadorId = ca.Id left join Reservaciones r
on r.ClienteId = c.Id or r.ClienteId = c.AfiliadorId inner join Paseos p
on p.Id = r.PaseoId left join Servicios_Consumidos sc
on sc.ReservacionId = r.Id and sc.ClienteId = c.Id inner join Servicios s
on sc.ServicioId = s.Id inner join Tipos_De_Servicios ts
on s.TipoId = ts.Id




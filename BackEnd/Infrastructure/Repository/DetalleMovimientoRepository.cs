using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository;
public class DetalleMovimientoRepository : GenericRepository<DetalleMovimiento>, IDetalleMovimiento
{
    private readonly DbAppContext _Context;
    public DetalleMovimientoRepository(DbAppContext context) : base(context)
    {
        _Context = context;
    }
    public override async Task<IEnumerable<DetalleMovimiento>> GetAllAsync()
    {
        return await _Context.Set<DetalleMovimiento>()
                                .Include(p => p.Medicamentos)
                                .ToListAsync();        
    }
}

namespace Core.Entities;

public class DetalleMovimiento : BaseEntity
{
    public int MedicamentoId { get; set; }
    public Medicamento? Medicamentos { get; set; }
    public int Cantidad { get; set; }

    public int MovimientoMedicamentoId { get; set; }
    public MovimientoMedicamento? MovimientosMedicamentos { get; set; }

    public int Precio { get; set; }


}

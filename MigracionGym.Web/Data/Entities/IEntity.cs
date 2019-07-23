namespace MigracionGym.Data.Entities
{

    public interface IEntity
    {
        int Id { get; set; }

        //TODO: Implementar para cuando se elimina algo, dejar marca, pero no eliminar realmente.
        //bool WasDeleted { get; set; }

    }
}

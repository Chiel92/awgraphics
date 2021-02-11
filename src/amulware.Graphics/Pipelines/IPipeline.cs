
namespace amulware.Graphics.Pipelines
{
    public interface IPipeline<in TState>
    {
        void Execute(TState state);
    }
}

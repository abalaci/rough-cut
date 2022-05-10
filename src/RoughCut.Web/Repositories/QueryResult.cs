namespace RoughCut.Web.Repositories
{
    public class QueryResult<TEntity>
    {
        public static readonly QueryResult<TEntity> NotFound = new() { Status = QueryResultStatus.NotFound };

        public QueryResultStatus Status { get; init; }

        public TEntity? Entity { get; init; }

        private QueryResult() { }

        public QueryResult(TEntity entity)
        {
            Status = QueryResultStatus.Success;
            Entity = entity;
        }
    }

    public enum QueryResultStatus
    {
        Success = 0,
        NotFound = 1,
    }
}

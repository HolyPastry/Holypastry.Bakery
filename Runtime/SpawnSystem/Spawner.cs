using UnityEngine;

namespace Holypastry.Bakery
{
    public class Spawner<T> where T : Spawnable
    {
        ISpawnStrategy _spawnStrategy;
        ISpawnableFactory<T> _entityFactory;

        public Spawner(ISpawnStrategy spawnStrategy, ISpawnableFactory<T> entityFactory)
        {
            _spawnStrategy = spawnStrategy;
            _entityFactory = entityFactory;
        }

        public virtual T Spawn()
        {
            Transform spawnPoint = _spawnStrategy.NextSpawnPoint();
            return _entityFactory.Create(spawnPoint);
        }
    }
}


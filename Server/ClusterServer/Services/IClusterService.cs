using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClusterServer.Services
{
   public interface IClusterService
    {
        List<Blog> GetBlogs();
        Cluster GetHierarchicalCluster();
        List<Centroid> GetKMeansCluster();
        List<Centroid> GetKMeansClusterSelfHalt();
    }
}

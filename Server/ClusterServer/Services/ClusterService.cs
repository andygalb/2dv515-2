using ClusterServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClusterServer
{
    public class ClusterService : IClusterService
    {
        List<Blog> blogs;
        String[] wordsList;
        String filename = "blogdata.txt";

        public ClusterService()
        {
            Loader l = new Loader();
            blogs=l.LoadBlogs(filename);
            wordsList = l.GetWordsList();
        }

        public List<Blog> GetBlogs()
        {
            return blogs;
        }
        public Cluster GetHierarchicalCluster()
        {
            Hierarchical H = new Hierarchical(blogs);
            List<Cluster> result = H.HierarchicalCluster();
            return result.First<Cluster>();
        }

        public List<Centroid> GetKMeansCluster()
        {
            KMean k = new KMean(blogs, wordsList, 5, 100);
            return k.KMeans();
        }

        public List<Centroid> GetKMeansClusterSelfHalt()
        {
            KMean k = new KMean(blogs, wordsList, 5, 100);
            return k.KMeansSelfHalting();
        }

    }
}

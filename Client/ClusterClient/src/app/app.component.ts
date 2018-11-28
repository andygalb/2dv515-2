import {Component, OnInit} from '@angular/core';
import {DataService, Centroid, Cluster} from './data.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'Cluster';
  centroids: Centroid[];
  haltCentroids: Centroid[];
  clusters: Cluster[];

  ngOnInit(): void {
  //  this.showKMeans();
   // this.showKMeansHalt();
    this.showHierarchical();
  }

  constructor(private dataService: DataService) {}

  showKMeans() {

    this.dataService.getKMeans()
      .subscribe((data: Centroid[]) =>
      {
        console.log(data);
        this.centroids = data;
      });
  }

  showKMeansHalt() {

    this.dataService.getKMeans()
      .subscribe((data: Centroid[]) =>
      {
        console.log(data);
        this.haltCentroids = data;
      });
  }

  showHierarchical() {

    this.dataService.getHierarchicalCluster()
      .subscribe((data: Cluster[]) =>
      {
        console.log(data);
        this.clusters = data;
      });
  }

}


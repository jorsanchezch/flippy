import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SoundGridComponent } from './sample/sound-grid/sound-grid.component';
import { SoundDetailComponent } from './sample/sound-detail/sound-detail.component';

const routes: Routes = [
    { path: '', component: SoundGridComponent },
    { path: ':id', component: SoundDetailComponent },
  ];
  
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

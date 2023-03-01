import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SoundDetailComponent } from './sample/sound-detail/sound-detail.component';
import { SoundGridComponent } from './sample/sound-grid/sound-grid.component';
import { SoundListComponent } from './sample/sound-list/sound-list.component';
import { SoundItemComponent } from './sample/sound-grid/sound-item/sound-item.component';
import { SearchBarComponent } from './search-bar/search-bar.component';
import { SearchPipe } from './pipes/search.pipe';
import { RouterTestingModule } from "@angular/router/testing";
import { SoundService } from './sample/services/sound.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    SoundDetailComponent,
    SoundGridComponent,
    SoundListComponent,
    SoundItemComponent,
    SearchBarComponent,
    SearchPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterTestingModule,
  ],
  providers: [SoundService],
  bootstrap: [AppComponent]
})
export class AppModule { }

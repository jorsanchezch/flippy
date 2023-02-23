import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SoundDetailComponent } from './sample/sound-detail/sound-detail.component';
import { SoundGridComponent } from './sample/sound-grid/sound-grid.component';
import { SoundListComponent } from './sample/sound-list/sound-list.component';
import { SoundItemComponent } from './sample/sound-grid/sound-item/sound-item.component';
import { SearchBarComponent } from './search-bar/search-bar.component';
import { SearchPipe } from './pipes/search.pipe';

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
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

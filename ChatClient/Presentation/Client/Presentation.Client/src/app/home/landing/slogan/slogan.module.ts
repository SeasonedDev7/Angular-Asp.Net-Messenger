import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';
import { SloganComponent } from './slogan.component';

@NgModule({
  declarations: [SloganComponent],
  imports: [
    CommonModule,
    TranslateModule.forChild({ extend: true })
  ],
  exports: [SloganComponent]
})
export class SloganModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthorizationModule } from './modules/authorization/authorization.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { QuestionsModule } from './modules/questions/questions.module';
import { AuthApiService } from './services/auth.service';
import { ConfigService } from './services/config.service';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AuthorizationModule,
    QuestionsModule,
    NgbModule,
    HttpClientModule,
  ],
  providers: [AuthApiService, ConfigService],
  bootstrap: [AppComponent],
})
export class AppModule {}

import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'new-announcement',
    title: 'New Announcement',
    loadComponent: () =>
      import('./new-announcement/new-announcement.component').then(
        (m) => m.NewAnnouncementComponent
      ),
  },
  {
    path: 'current-announcements',
    title: 'Current Announcements',
    loadComponent: () =>
      import('./current-announcements/current-announcements.component').then(
        (m) => m.CurrentAnnouncementsComponent
      ),
  },
  // {path: "current-announcements/:id", component: AnnouncementComponent},
  {
    path: 'announcement-log',
    title: 'Announcement Log',
    loadComponent: () =>
      import('./announcement-log/announcement-log.component').then(
        (m) => m.AnnouncementLogComponent
      ),
  },
  // {path: "announcement-log/:id", component: AnnouncementLogComponent},
  {
    path: 'setup',
    title: 'Setup',
    loadComponent: () =>
      import('./setup/setup.component').then((m) => m.SetupComponent),
  },
  // {path: "setup/templates", component: TemplatesComponent},
  // {path: "setup/variables", component: VariablesComponent},
  // {path: "setup/settings", component: SettingsComponent},
  // {path: "setup/users", component: UsersComponent},
  { path: '', redirectTo: '/new-announcement', pathMatch: 'full' },
  {
    path: '**',
    title: 'Page Not Found',
    loadComponent: () =>
      import('./page-not-found/page-not-found.component').then(
        (m) => m.PageNotFoundComponent
      ),
  },
];

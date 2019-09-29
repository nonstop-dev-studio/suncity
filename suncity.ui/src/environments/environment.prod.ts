const apiUrl = 'https://localhost:44398/api/';

export const environment = {
  production: true,
  authRequest: apiUrl + 'account/login',
  register: apiUrl + 'account/register',
  postQuestionnaire: apiUrl + 'questionnaires',
  getQuestionnaire: apiUrl + 'questionnaires',
  postReport: apiUrl + 'reports',
  getReport: apiUrl + 'reports',
  getUser: apiUrl + 'account/current'
};

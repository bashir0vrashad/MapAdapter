using MapAdapter;

Employer employer = new Employer ( "Rashad",  "Bashirov", "777" );
employer.DisplayInfo();


IMapService adapter = new EmployerMapAdapter(employer);
adapter.DisplayOnMap(new PersonInfo ("Rashad", "Bashirov"));
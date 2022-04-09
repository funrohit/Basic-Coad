using CrudBootstrap.DB_Connect;
using CrudBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CrudBootstrap.Controllers
{
[HtppGet]
public ActionResult index(){
	
	return view();
}

[HtppPost]
public ActionResult index (mymodel obj){
	
	helpentity database = new helpentity();
	
	var res= database.mytable.Where(a=>a.email== obj.email).FirstorDefault();
	
if(res==null){
	tempdata[invalid]="this is invalid email";
}
else{
			if(res.email==obj.email && res.password==obj.password){
				FormsAuthentication.SetAuthCookie(Res.email, false);
				
				

			}
				tempdata[no]="plz try again";
}

	
	return RedirectToAction("home","dashboard");
}

	public ActionResult logoff(){
		FormsAuthentication.SignOut();
            return RedirectToAction("Index");
		
	}
	
	public ActionResult show(){
		
		helpentity database = new database();
		
			List<mymodel> mm = new List<mymodel>
		
		foreach(var item in mymodel){
			
			mm.Add( new mymodel
			{
			mm.id=id,
			mm.name=name,
			mm.email=email
			});
			}
		
		database.mytable.Add(mm);
		database.saveChange();
		
		return RedirectToAction(mm);
		

	}


Activity activity = new Activity();
BreathingActivity calm = new BreathingActivity("calm", "Breathing Activity for Calming", "Thank you for doing this activity");
ReflectingActivity reflect = new ReflectingActivity("reflect", "Reflecting Activity", "Thank you for completing this activity");
ListingActivity list = new ListingActivity("counting your blessings", "Listing Activity to count your blessings", "Thank you for completing this activity");

calm.StartBreathingActivity();

Console.Clear();
reflect.StartReflectionAcivity();

Console.Clear();
list.StartListingActivity();
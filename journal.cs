// NX 2206
// Journal created by dojin on Thu Aug 10 17:44:22 2023 대한민국 표준시

//
using System;
using NXOpen;

public class NXJournal
{
  public static void Main(string[] args)
  {
    NXOpen.Session theSession = NXOpen.Session.GetSession();
    NXOpen.Part workPart = theSession.Parts.Work;
    NXOpen.Part displayPart = theSession.Parts.Display;
    // ----------------------------------------------
    //   Menu: File->Exit
    // ----------------------------------------------

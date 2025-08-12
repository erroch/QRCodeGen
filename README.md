# QR Code Gen
A QR code generator.

  ### About
  This is a quick and dirty QR code generator that supports adding an icon in the center of the resulting image.
  Image icon doesn't work with SVG saved QR codes.

  I needed some QR codes with an icon, and every I looked wanted me to pay for it, or made QR codes with their own redirect.
  The code is ugly, probably has a small heap of bugs, but I needed a fast solution.

  Leans on the QRCoder nuget package for actual QR code generation.
 
  ### To Use
  Type the target URL (or whatever text you want to encoded) in the URL field.  Click Save.
  
  ECC (Error Correction Compatability) support level L, M, Q and H (7%, 15%, 25%, 30% respectively), defaults to L.
  There are no constraints on icon size and going over ECC limits may cause QR code to be unreadable.
  Use icons with care.
  
  ### Known Issues
  Considering this is maybe an hour or so's worth of work, probably many.
  Image % doesn't seem to be quite accurate, but it's close enough for my needs.
  
  

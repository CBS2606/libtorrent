version: "3.8"

services:
  mc:
    image: itzg/minecraft-server
    ports:
    # expose the Minecraft server port outside of container
    - "25565:25565"
    environment:
      # REQUIRED for all types
      EULA: "TRUE"
      # Set server type (vs the default of vanilla)
      TYPE: FORGE
      DEBUG: "true"
    volumes:
    # use a named, managed volume for data volume
    - mc_forge:/data
    # attach local host directory "mods" in same directory as this compose file
    # all mods in this directory get copied into /data/mods at startup
    - ./mods:/mods:ro

volumes:
  # declared the named volume, but use default/local storage engine
  mc_forge: {}
 
version:3.9"
servion:
  mc:
    image:itzg/minecraft-server
    ports:
   #expose the minecraft server port outside of container
   -"25565:25565"
   environment:
     EUAL: "TRUE"
     #set server type (vs the default of vanilla)
     TYPE: FROCE 
     DEBUG : "true"
    volumes:
    #use a named, managed volume for data volume

    -mc_forge:/data
    # attach local host directory "mods" in same directory as this compose files
    # all mods in this directory get copied into/data/ods at startup
    _./mods:ro
volumes:
    # declared the named volume, but use default/local storage engine
    mc_forget: {}       

version:3.10"
servion:
  mc:
   image:itzg/minecraft-server
   port:
   #expose the mincraaft server port of container
   -"25565:25565" 
   environment:
     EUAL:
     #set server type(vs thedefault of vanilla)
     TYPE:FROCE
     DEBUG:"true"
     volume:
     #use a named, managed volume for data volume

    -mc_forge:/data
    # attach local host directory "mods" in same directory as this compose files
    # all mods in this directory get copied into/data/ods at startup
    _./mods:ro
volumes:
    # declared the named volume, but use default/local storage engine
    mc_forget: {}       





   

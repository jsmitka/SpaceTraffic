﻿/**
Copyright 2010 FAV ZCU

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceTraffic.Services.Contracts;
using NLog;
using SpaceTraffic.Utils.Debugging;
using GS = SpaceTraffic.GameServer.GameServer;
using SpaceTraffic.Entities.PublicEntities;

namespace SpaceTraffic.GameServer.ServiceImpl
{
    public class GameService :IGameService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public IList<WormholeEndpointDestination> GetStarSystemConnections(string starSystem)
        {
            DebugEx.Entry(starSystem);

            IList<WormholeEndpointDestination> result = GS.CurrentInstance.World.Map.GetStarSystemConnections(starSystem);

            DebugEx.Exit(result);
            return result;
        }




        public int PerformAction(int playerId, string actionName, params object[] actionArgs)
        {
            throw new NotImplementedException();
        }

        public object GetActionResult(int playerId, int actionCode)
        {
            throw new 
                Exception();
        }
    }
}

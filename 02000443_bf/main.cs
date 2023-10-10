namespace Maple2.Trigger._02000443_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.EnableSpawnPointPc(spawnId: 11001, enabled: true);
                context.EnableSpawnPointPc(spawnId: 11002, enabled: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1003, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2198, 2199}, visible: false);
                context.SetMesh(triggerIds: new []{2150}, visible: true);
                context.MoveUser(mapId: 02000443, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetGravity(gravity: -25f);
                context.CreateMonster(spawnIds: new []{210}, arg2: true);
                context.EnableSpawnPointPc(spawnId: 11001, enabled: false);
                context.EnableSpawnPointPc(spawnId: 11002, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enabled: false);
                context.CreateMonster(spawnIds: new []{211}, arg2: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000443_BF__MAIN__0$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000443_BF__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$02000443_BF__MAIN__1$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000443_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2005");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2006");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

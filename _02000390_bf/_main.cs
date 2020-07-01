namespace Maple2.Trigger._02000390_bf {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
                context.SetMesh(arg1: new[] {1001, 1002, 1003}, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125,
                        2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141,
                        2142, 2143, 2144, 2145, 2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157,
                        2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173,
                        2174, 2175, 2176, 2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189,
                        2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2198, 2199
                    }, arg2: false);
                context.MoveUser(arg1: 02000390, arg2: 2);
                context.SetLocalCamera(cameraId: 8001, enable: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new StatedungeonReady(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StatequestReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatedungeonReady : TriggerState {
            internal StatedungeonReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetLocalCamera(cameraId: 8001, enable: true);
                context.SetGravity(gravity: -25f);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatequestReady : TriggerState {
            internal StatequestReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetLocalCamera(cameraId: 8001, enable: true);
                context.SetGravity(gravity: -25f);
                context.CreateMonster(arg1: new[] {210}, arg2: true);
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001517},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestEnd(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd : TriggerState {
            internal StateQuestEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {210, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000390_BF__MAIN__0$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000390_BF__MAIN__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000390_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000390_BF__MAIN__3$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2006");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
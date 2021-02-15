namespace Maple2.Trigger._02000536_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {501, 502, 504, 505, 506, 507, 508, 509, 510, 511}, arg2: false);
                context.SetInteractObject(arg1: new[] {10003147}, arg2: 0);
                context.SetMesh(arg1: new[] {9999}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSceneSkip();
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "전투시작", arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {7000, 7003}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$02000536_BF__MAIN__0$", desc: "$02000536_BF__MAIN__1$", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State하렌인사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌인사 : TriggerState {
            internal State하렌인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7003, 7001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Bore_A", arg3: 5000f);
                context.AddCinematicTalk(npcId: 23300001, msg: "$02000536_BF__MAIN__2$", align: "center", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State하렌인사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌인사2 : TriggerState {
            internal State하렌인사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_01_E,Attack_01_B");
                context.AddCinematicTalk(npcId: 23300001, msg: "$02000536_BF__MAIN__3$", align: "center", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, arg2: "$02000536_BF__MAIN__4$", arg3: 3000);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.70f) {
                    return new State메이드군단을Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이드군단을Spawn : TriggerState {
            internal State메이드군단을Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 4000, script: "$02000536_BF__MAIN__5$");
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.50f) {
                    return new State메이드군단을Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이드군단을Spawn2 : TriggerState {
            internal State메이드군단을Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401, 402, 403, 404}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.30f) {
                    return new StateMonsterDead체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead체크 : TriggerState {
            internal StateMonsterDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 4000, script: "$02000536_BF__MAIN__6$");
                context.CreateMonster(arg1: new[] {201, 202, 203, 204}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State던전Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전Clear : TriggerState {
            internal State던전Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 3000, script: "$02000536_BF__MAIN__8$");
                context.SetMesh(arg1: new[] {9999}, arg2: false);
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger완료 : TriggerState {
            internal StateTrigger완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52020031_qd {
    public static class _main30000333 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{30000333}, questStates: new byte[]{1})) {
                    return new State두번째SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째SetupCinematic : TriggerState {
            internal State두번째SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State두번째SetupCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째SetupCinematic_01 : TriggerState {
            internal State두번째SetupCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째SetupCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째SetupCinematic_02 : TriggerState {
            internal State두번째SetupCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020031, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic : TriggerState {
            internal State두번째Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, script: "천공의 심장을 돌려줘.", duration: 3000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State두번째Cinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_01 : TriggerState {
            internal State두번째Cinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State두번째Cinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_02 : TriggerState {
            internal State두번째Cinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003756, script: "곱게 가져갈 수 있을 거라고 생각해?", duration: 3000);
                context.AddCinematicTalk(npcId: 11003756, script: "꿈도 야무지다니까... 호호호", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째Cinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_03 : TriggerState {
            internal State두번째Cinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째Cinematic전투Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic전투Prepare_01 : TriggerState {
            internal State두번째Cinematic전투Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State두번째Cinematic전투Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic전투Prepare : TriggerState {
            internal State두번째Cinematic전투Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State두번째Cinematic전투Prepare1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic전투Prepare1 : TriggerState {
            internal State두번째Cinematic전투Prepare1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{601}, arg2: false);
                context.SetEventUI(arg1: 1, script: "하렌을 처치하세요!", duration: 2000, boxId: 0);
                context.AddBalloonTalk(spawnId: 601, msg: "숨통을 끊어주마.", duration: 3000, delayTick: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601})) {
                    return new State두번째Cinematic전투종료1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic전투종료1 : TriggerState {
            internal State두번째Cinematic전투종료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.5f);
                context.MoveUser(mapId: 52020031, portalId: 6001);
                context.DestroyMonster(spawnIds: new []{601});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째Cinematic전투종료2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic전투종료2 : TriggerState {
            internal State두번째Cinematic전투종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

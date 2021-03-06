using System.Numerics;

namespace Maple2.Trigger._02000543_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(17f, 196f, 181f), arg2: new Vector3(0f, 0f, 0f));
                context.SetMesh(arg1: new[] {5000, 5001}, arg2: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.SetEffect(arg1: new[] {3000, 3002, 3001, 3003, 3004, 3005}, arg2: false);
                context.SetSkill(arg1: new[] {4000, 4001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 106, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703}, arg2: 0)) {
                    return new State뒤큐브날리기전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒤큐브날리기전 : TriggerState {
            internal State뒤큐브날리기전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {4000}, arg2: true);
                context.CreateMonster(arg1: new[] {104, 105, 110}, arg2: false);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State뒤큐브날리기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒤큐브날리기 : TriggerState {
            internal State뒤큐브날리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3001}, arg2: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 3000, script: "$02000543_BF__MAIN__0$");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 0)) {
                    return new State게임안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임안내 : TriggerState {
            internal State게임안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {7000}, arg2: false);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 3000, script: "$02000543_BF__MAIN__1$");
                context.LockMyPc(isLock: true);
                context.SetMesh(arg1: new[] {5000, 5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게임안내2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임안내2 : TriggerState {
            internal State게임안내2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {7000}, arg2: true);
                context.LockMyPc(isLock: false);
                context.AddBalloonTalk(spawnPointId: 104, msg: "$02000543_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 105, msg: "$02000543_BF__MAIN__3$", duration: 3500, delayTick: 500);
                context.CreateMonster(arg1: new[] {107}, arg2: true);
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.CreateMonster(arg1: new[] {106}, arg2: true);
                context.CreateMonster(arg1: new[] {112}, arg2: false);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000543_BF__MAIN__4$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State게임설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임설정 : TriggerState {
            internal State게임설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000, script: "$02000543_BF__MAIN__5$");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(arg1: new[] {3002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조건체크MonsterSpawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크MonsterSpawn1 : TriggerState {
            internal State조건체크MonsterSpawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {110});
                context.SetEventUI(arg1: 1, script: "$02000543_BF__MAIN__6$", arg3: 3000);
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "main") == 4) {
                    return new State조건체크MonsterSpawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크MonsterSpawn2 : TriggerState {
            internal State조건체크MonsterSpawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State조건체크MonsterSpawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크MonsterSpawn3 : TriggerState {
            internal State조건체크MonsterSpawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {108})) {
                    return new State2단계가기전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계가기전1 : TriggerState {
            internal State2단계가기전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2단계가기전2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계가기전2 : TriggerState {
            internal State2단계가기전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000543_BF__MAIN__7$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAiExtraData(key: "phaseSecond", value: 1);
                    return new State2단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계 : TriggerState {
            internal State2단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "main") == 5) {
                    return new State2단계시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계시작 : TriggerState {
            internal State2단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State2단계ConditionCheckMonster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계ConditionCheckMonster : TriggerState {
            internal State2단계ConditionCheckMonster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 107, msg: "$02000543_BF__MAIN__8$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {109})) {
                    return new State3단계시작전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계시작전1 : TriggerState {
            internal State3단계시작전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3단계시작전2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계시작전2 : TriggerState {
            internal State3단계시작전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAiExtraData(key: "phaseSecond", value: 5);
                    context.SetAiExtraData(key: "phase", value: 5);
                    return new State3단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계 : TriggerState {
            internal State3단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000543_BF__MAIN__9$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조건체크MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크MonsterSpawn : TriggerState {
            internal State조건체크MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000, script: "$02000543_BF__MAIN__10$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "main") == 8) {
                    return new State응접실문열기전MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열기전MonsterSpawn : TriggerState {
            internal State응접실문열기전MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102})) {
                    return new State응접실문Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문Wait : TriggerState {
            internal State응접실문Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(201f, 38f, 70f), arg2: new Vector3(0f, 0f, 0f));
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, script: "$02000543_BF__MAIN__11$", arg3: 3000);
                context.DestroyMonster(arg1: new[] {106, 107});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State응접실문열기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열기1 : TriggerState {
            internal State응접실문열기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3003}, arg2: true);
                context.LockMyPc(isLock: true);
                context.SideNpcTalk(npcId: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 3000, script: "$02000543_BF__MAIN__12$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State응접실문열기11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열기11 : TriggerState {
            internal State응접실문열기11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3000, 3002}, arg2: false);
                context.SetEffect(arg1: new[] {3004, 3005}, arg2: true);
                context.SideNpcTalk(npcId: 21450036, illust: "DesertDragonMagicGreen_normal", duration: 4000, script: "$02000543_BF__MAIN__13$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State응접실문열기31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열기31 : TriggerState {
            internal State응접실문열기31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000543_BF__MAIN__14$", arg3: 3000);
                context.DestroyMonster(arg1: new[] {111, 112});
                context.SetEffect(arg1: new[] {3004, 3005}, arg2: false);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State응접실문열기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열기4 : TriggerState {
            internal State응접실문열기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(arg1: new[] {4001}, arg2: true);
                context.SetEffect(arg1: new[] {3003}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 104, msg: "$02000543_BF__MAIN__15$", duration: 3500);
                context.AddBalloonTalk(spawnPointId: 105, msg: "$02000543_BF__MAIN__16$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State응접실문열고나서처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State응접실문열고나서처리 : TriggerState {
            internal State응접실문열고나서처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000543_BF__MAIN__17$");
                context.DestroyMonster(arg1: new[] {104, 105});
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702}, arg2: 0)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossSpawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn2 : TriggerState {
            internal StateBossSpawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new[] {103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103})) {
                    return new StatePortal열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열기 : TriggerState {
            internal StatePortal열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
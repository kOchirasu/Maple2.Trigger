namespace Maple2.Trigger._99999999_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5000, 8900, 8901, 8902, 8903, 8904, 8905}, visible: true);
                context.SetEffect(triggerIds: new []{8000, 8001}, visible: false);
                context.SetSkill(triggerIds: new []{9000}, enabled: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: false);
                context.EnableSpawnPointPc(spawnId: 3, enabled: false);
                context.EnableSpawnPointPc(spawnId: 4, enabled: false);
                context.EnableSpawnPointPc(spawnId: 5, enabled: false);
                context.EnableSpawnPointPc(spawnId: 6, enabled: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCamera경로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera경로 : TriggerState {
            internal StateCamera경로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.CameraSelectPath(pathIds: new []{7000, 7001}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.SetEventUI(arg1: 1, script: @"까마득한 성채를 따라 내려가야 합니다.\n몰려오는 어둠을 조심하세요.", duration: 3000);
                context.CreateMonster(spawnIds: new []{101, 1011, 1012, 1013, 1014, 1017, 1018, 1019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 1011, 1012, 1013, 1014, 1017, 1018, 1019})) {
                    return new State도마뱀Spawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도마뱀Spawn1 : TriggerState {
            internal State도마뱀Spawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8900}, visible: false);
                context.CreateMonster(spawnIds: new []{1015, 1016}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702}, jobCode: 0)) {
                    return new State702시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702시작 : TriggerState {
            internal State702시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.CreateMonster(spawnIds: new []{102, 1022, 1023, 1024, 1025}, arg2: true);
                context.SideNpcTalk(npcId: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000, script: "인간? 이게 얼마 만에 맡아보는 인간 냄새인지... 아주 향긋하군. 천천히 어둠 속으로 내려오라고.");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 1022, 1023, 1024, 1025})) {
                    return new State702마무리1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702마무리1 : TriggerState {
            internal State702마무리1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8901}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State702마무리2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702마무리2 : TriggerState {
            internal State702마무리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "불쌍한 인간... 샘은 이미 너를 주시하고 있어. 어둠이 너를 쫓을거야.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703}, jobCode: 0)) {
                    return new State703시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703시작 : TriggerState {
            internal State703시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1026});
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State703진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703진행 : TriggerState {
            internal State703진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"어둠의 샘이 당신의 존재를 눈치챘습니다.\n생명을 탐하는 검은 화살이 당신을 뒤쫓습니다.", duration: 3000);
                context.CreateMonster(spawnIds: new []{109, 103, 1031, 1032, 1033, 1034}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103, 1031, 1032, 1033, 1034})) {
                    return new State703마무리1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703마무리1 : TriggerState {
            internal State703마무리1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8902}, visible: false);
                context.CreateMonster(spawnIds: new []{1035}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State703마무리2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703마무리2 : TriggerState {
            internal State703마무리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "수백년간 잠들어 있던 샘이 깨어났어. 샘은 영혼을 원해. 가까이 다가가지 않는게 좋아.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State704시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State704시작 : TriggerState {
            internal State704시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 2, enabled: false);
                context.EnableSpawnPointPc(spawnId: 3, enabled: true);
                context.CreateMonster(spawnIds: new []{104, 1041, 1042, 1043, 1044}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State704진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State704진행 : TriggerState {
            internal State704진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "거미... 난 거미가 싫어... 거미는 영혼을 옭아매는 자...");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104, 1041, 1042, 1043, 1044})) {
                    return new State704마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State704마무리 : TriggerState {
            internal State704마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8903}, visible: false);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "샘은 거미의 눈을 빌려 모든걸 감시하고 있어. 조심하는게 좋아.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new State705시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State705시작 : TriggerState {
            internal State705시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 3, enabled: false);
                context.EnableSpawnPointPc(spawnId: 4, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State705진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State705진행 : TriggerState {
            internal State705진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105, 1051, 1052, 1053, 1054}, arg2: true);
                context.SideNpcTalk(npcId: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000, script: "얼마 안남았어. 조금 더... 조금 더 내려와봐.");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105, 1051, 1052, 1053, 1054})) {
                    return new State705마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State705마무리 : TriggerState {
            internal State705마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8904}, visible: false);
                context.CreateMonster(spawnIds: new []{1036}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new StateBuff걸어주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff걸어주기 : TriggerState {
            internal StateBuff걸어주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "여기 들어온 순간...");
                context.SetSkill(triggerIds: new []{9000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new State706시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State706시작 : TriggerState {
            internal State706시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "어둠을 만나게 되면... 다신 올라올 수 없어.");
                context.EnableSpawnPointPc(spawnId: 4, enabled: false);
                context.EnableSpawnPointPc(spawnId: 5, enabled: true);
                context.CreateMonster(spawnIds: new []{106, 1061, 1063, 1064, 1065}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106, 1061, 1063, 1064, 1065})) {
                    return new State706마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State706마무리 : TriggerState {
            internal State706마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8905}, visible: false);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "그래 마치 우리처럼...");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707}, jobCode: 0)) {
                    return new State707시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State707시작 : TriggerState {
            internal State707시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 5, enabled: false);
                context.EnableSpawnPointPc(spawnId: 6, enabled: true);
                context.CreateMonster(spawnIds: new []{108}, arg2: true);
                context.SideNpcTalk(npcId: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000, script: "캬하하! 여기까지 오다니, 재미있겠는걸. 네 영혼도 여기에 묶어주마.");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{108})) {
                    return new StatePortalCreation전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation전 : TriggerState {
            internal StatePortalCreation전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{109});
                context.CreateMonster(spawnIds: new []{1091}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortalCreation전2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation전2 : TriggerState {
            internal StatePortalCreation전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{109});
                context.CreateMonster(spawnIds: new []{1091}, arg2: true);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "잠깐, 더 내려 갈거야? 여기서 어디로 갈지 우린 알 수 없어. 여긴 뒤틀린 미지의 공간. 모든 것은 샘의 뜻대로...");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

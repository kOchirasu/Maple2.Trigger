using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000118_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100015}, questStates: new byte[]{2})) {
                    return new StateFadeout(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100015}, questStates: new byte[]{3})) {
                    return new StateFadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSceneSkip(state: new StateFadeout_a(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuspiciousmask(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuspiciousmask : TriggerState {
            internal StateSuspiciousmask(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002, 4003}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__0$", duration: 3000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDooropen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDooropen : TriggerState {
            internal StateDooropen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJordyspawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyspawn : TriggerState {
            internal StateJordyspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__1$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJordyin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyin : TriggerState {
            internal StateJordyin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__3$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateJordyhello(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyhello : TriggerState {
            internal StateJordyhello(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__4$", duration: 1000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHuk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHuk : TriggerState {
            internal StateHuk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Sit_Down_A", duration: 1000f);
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__5$", duration: 1000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuspiciousmaskmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuspiciousmaskmove : TriggerState {
            internal StateSuspiciousmaskmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Attack_Idle_A", duration: 10000f);
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__7$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__8$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_03 : TriggerState {
            internal StateTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__9$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__10$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_04 : TriggerState {
            internal StateTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__11$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKillyou(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKillyou : TriggerState {
            internal StateKillyou(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__12$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_05 : TriggerState {
            internal StateTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__13$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_06 : TriggerState {
            internal StateTalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, enabled: true);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__14$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_01 : TriggerState {
            internal StateCamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_02 : TriggerState {
            internal StateCamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_07 : TriggerState {
            internal StateTalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__15$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalk_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_08 : TriggerState {
            internal StateTalk_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__16$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalk_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_09 : TriggerState {
            internal StateTalk_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__18$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_10 : TriggerState {
            internal StateTalk_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__19$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003186, script: "$52000118_QD__MAIN__20$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_11 : TriggerState {
            internal StateTalk_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__21$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_12 : TriggerState {
            internal StateTalk_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3005");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3003");
                context.AddBalloonTalk(spawnId: 102, msg: "$52000118_QD__MAIN__22$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003167, script: "$52000118_QD__MAIN__23$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_a : TriggerState {
            internal StateFadeout_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.VisibleMyPc(visible: true);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadein_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_a : TriggerState {
            internal StateFadein_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000118_QD__MAIN__24$", duration: 3000, boxId: 0);
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
